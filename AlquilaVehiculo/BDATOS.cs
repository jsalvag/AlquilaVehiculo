using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace AlquilaVehiculo {
    class BDATOS {
        string nomDB;
        OleDbConnection db;
        OleDbDataAdapter da;
        OleDbCommand com;
        DataTable dt, st;
        DataSet ds;

        //.\\ALQUILERDECARROS.accdb
        public BDATOS(string bdatos) {
            this.nomDB = bdatos;
            conectar(this.nomDB);
        }

        public bool conectar(string bd) {
            this.db = new OleDbConnection();
            this.db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + bd;
            try {
                this.db.Open();
                return true;
            } catch(OleDbException ex) { MessageBox.Show(ex.Message); }
            return false;
        }

        public void cerrar() {
            this.db.Close();
        }

        public void limpiar() {
            this.db.Dispose();
        }

        public DataTable buscar(string campo, string tabla, string condicion) {
            dt = new DataTable();
            ds = new DataSet();
            ds.Tables.Add(dt);
            string sql = "SELECT " + campo + " FROM " + tabla + " " + condicion;
            sql = sql.Trim();
            sql += ";";
            try {
                da = new OleDbDataAdapter(sql, db);
                da.Fill(dt);
                return dt;
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public bool insertar(string tabla, string valores) {
            conectar(nomDB);
            string val1 = "", val2 = "";
            string[] d1 = valores.Split(',');
            st = new DataTable();
            st = db.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new Object[] { null, null, tabla, null });
            //foreach (DataRow dr in st.Rows)
            //    MessageBox.Show(dr.ItemArray[3].ToString());
            string[] dc = new string[st.Rows.Count];
            string[] d2 = new string[dc.Length];

            for(int i = 0; i < st.Rows.Count; i++) {
                dc[i] = st.Rows[i].ItemArray[3].ToString();
                val1 += dc[i] + ',';
                d2[i] = "@" + dc[i];
                val2 += d2[i] + ',';
            }

            val1 = val1.Trim(',');
            val2 = val2.Trim(',');

            //EMPLEADOS
            //"INSERT INTO [EMPLEADOS] (ape,cargo,ci,clave,Dir,fecha_ingreso,fNac,nom,oficina,sexo,sueldo,telf,usuario)
            //VALUES (@ape,@cargo,@ci,@clave,@Dir,@fecha_ingreso,@fNac,@nom,@oficina,@sexo,@sueldo,@telf,@usuario);"

            //CLIENTES
            //"INSERT INTO [CLIENTES] (ape,ci,Dir,fecha_afiliacion,fNac,nom,sexo,telf)
            //VALUES (@ape,@ci,@Dir,@fecha_afiliacion,@fNac,@nom,@sexo,@telf);"

            //VEHICULOS
            //"INSERT INTO [VEHICULOS] (aire,alfombras,anio,antena,bat_amp,bat_fecha,bat_marca,bat_serial,categoria,cauchos,ceniceros,cinturon,color,encendedor,espejos_lat,
            //                          gas_actu,gas_ante,gato,k_actu,k_ante,limpia_vid,marca,modelo,oficina,placa,precio,radio,seguro,tapa_gas,tazas,tranca,triangulo)
            //VALUES (@aire,@alfombras,@anio,@antena,@bat_amp,@bat_fecha,@bat_marca,@bat_serial,@categoria,@cauchos,@ceniceros,@cinturon,@color,@encendedor,@espejos_lat,@gas_actu,@gas_ante,@gato,@k_actu,@k_ante,@limpia_vid,@marca,@modelo,@oficina,@placa,@precio,@radio,@seguro,@tapa_gas,@tazas,@tranca,@triangulo);"

            //ALQUILERES
            //"INSERT INTO [ALQUILERES] (cierre,cliente,cod,entregado,fecha_alquiler,inicio,lavado,observa,preparado,recibido,vehiculo)
            //VALUES (@cierre,@cliente,@cod,@entregado,@fecha_alquiler,@inicio,@lavado,@observa,@preparado,@recibido,@vehiculo);"

            string sql = "INSERT INTO [" + tabla + "] (" + val1 + ") VALUES (" + val2 + ");";
            try {
                paramEmpleados(sql, d1, d2, dc.Length);

                com.ExecuteNonQuery();

                return true;
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                db.Close();
                com.Dispose();
            }
            return false;
        }

        private void paramEmpleados(string sql, string[] d1, string[] d2, int x) {
            try {
                com = new OleDbCommand(sql, this.db);

                for(int i = 0; i < x; i++) {
                    if(i == 5 || i == 6)
                        com.Parameters.AddWithValue(d2[i], Convert.ToDateTime(d1[i]));
                    else if(i == 10)
                        com.Parameters.AddWithValue(d2[i], Convert.ToDouble(d1[i]));
                    else
                        com.Parameters.AddWithValue(d2[i], d1[i]);
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
