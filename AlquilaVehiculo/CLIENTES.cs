using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace AlquilaVehiculo
{
    class CLIENTES
    {
        private string
            ci,
            nom,
            ape,
            sexo,
            dir,
            telf;
        private DateTime
            fNac,
            fAfil;

        public CLIENTES(string c, string n, string a, string s, string d, string t, DateTime fn, DateTime fa)
        {
            this.ci = c;
            this.nom = n;
            this.ape = a;
            this.sexo = s;
            this.dir = d;
            this.telf = t;
            this.fNac = fn;
            this.fAfil = fa;
        }

        public int getEdad()
        {
            TimeSpan edad = DateTime.Now - fNac;
            Double e = edad.TotalDays;
            e /= 365.25;
            return Convert.ToInt16(e);
        }

        public void setDir(string d)
        {
            this.dir = d;
        }

        public void setTelf(string t)
        {
            this.telf = t;
        }

        public Boolean guardar(OleDbConnection db)
        {
            return false;
        }
    }
}
