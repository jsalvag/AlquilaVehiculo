using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AlquilaVehiculo
{
    public partial class LogIn : Form
    {
        private string user, clave, ci;
        DataTable dt;
        BDATOS db;

        public LogIn()
        {
            InitializeComponent();
            try
            {
                dt = new DataTable();
                db = new BDATOS(".\\ALQUILERDECARROS.accdb");
                dt = db.buscar("*", "EMPLEADOS", "");
                db.cerrar();
                db.limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Focused)
                tb.SelectAll();
            if (tb.Name == "logClave")
                tb.PasswordChar = '*';
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void etrar(object sender, EventArgs e)
        {
            user = logUser.Text;
            clave = logClave.Text;
            int check = chequearUsuario(user,clave);
            if (check==0)
            {
                MessageBox.Show("Usuario inválido");
                logClave.Text = "";
                logUser.Focus();
                logUser.SelectAll();
            }
            else if (check == 2)
            {
                MessageBox.Show("Clave inválida");
                logClave.Text = "";
                logClave.Focus();
            }
            else if (check == 1)
            {
                Form F = new PPL(this, ci);
                F.Show();
                this.Hide();
            }
        }

        public int chequearUsuario(string u, string p)
        {
            try
            {
                foreach (DataRow dr in dt.Rows)
                    if (dr[11].ToString() == u && dr[12].ToString() == p)
                    {
                        ci = dr[0].ToString();
                        return 1;
                    }
                    else if (dr[11].ToString() == u)
                        return 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
