using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDocente
{
    class Docente
    {
        private String dni;
        private String nombre;
        private Double sueldo;
        private int anoNac;

        public Docente()
        {
            this.dni = "9999999999";
            this.nombre = "NA";
            this.sueldo = 0;
            this.anoNac = 1900;
        }
        public string DNI
        {
            set
            {
                this.dni = value;
            }
            get
            {
                return this.dni;
            }
        }
        public String Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        public double Sueldo
        {
            set
            {
                this.sueldo = value;
            }
            get
            {
                return this.sueldo;
            }
        }
        public int AnoNac
        {
            set
            {
                this.anoNac = value;
            }
            get
            {
                return this.anoNac;
            }
        }
    }
}
