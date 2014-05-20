using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace AlquilaVehiculo
{
    class CLIENTES : PERSONA {
        private DateTime
            fAfil;

        public CLIENTES(string c, string n, string a, string s, string d, string t, DateTime fn, DateTime fa)
            : base(c, n, a, s, d, t, fn) {
            this.fAfil = fa;
        }

        public void setDir(string d) {
            base.dir = d;
        }

        public void setTelf(string t) {
            base.telf = t;
        }
    }
}
