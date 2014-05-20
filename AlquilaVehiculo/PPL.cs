using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AlquilaVehiculo {
    public partial class PPL : Form {
        Form F1;
        string userCI;
        BDATOS db;

        public PPL(Form f1, string ci) {

            this.F1 = f1;
            this.userCI = ci;
            InitializeComponent();
            box_user.BackColor = System.Drawing.Color.White;
            try {
                db = new BDATOS("|DataDirectory|\\ALQUILERDECARROS.accdb");
                box_user.Text = db.buscar("ape+', '+nom AS nombre", "EMPLEADOS", "WHERE ci='" + ci + "'").Rows[0].ItemArray[0].ToString().ToUpper();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                //db.insertar("EMPLEADOS", "marcano,agente,3489436,123456,porlamar,19-05-2014,18-10-1983,maria,porlamar,Femenino,7500,02952642303,mari");
                db.cerrar();
                db.limpiar();
            }
        }

        private void PPL_FormClosed(object sender, FormClosedEventArgs e) {
            F1.Close();
        }

        private void sm_salir_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
