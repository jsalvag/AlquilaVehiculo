using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquilaVehiculo {
    class PERSONA {
        protected string
            ci,
            nom,
            ape,
            sexo,
            dir,
            telf;
        protected DateTime
            fNac;

        public PERSONA(string c, string n, string a, string s, string d, string t, DateTime fn) {
            this.ci = c;
            this.nom = n;
            this.ape = a;
            this.sexo = s;
            this.dir = d;
            this.telf = t;
            this.fNac = fn;
        }

        public int getEdad() {
            int edad = DateTime.Now.Year - this.fNac.Year;

            DateTime diaNac = this.fNac.AddYears(edad);

            if(DateTime.Now.CompareTo(diaNac) > 0)
                edad--;

            return edad;
        }
    }
}
