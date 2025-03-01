using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesDeDatos
{
    class Agenda
    {
        private String dni;
        private String nombre;
        private String correo;
        private int anoNacimiento;
        private String telefono;

        public Agenda()
        {
            this.dni = "9999999999";
            this.nombre = "NA";
            this.correo = "na@na.com";
            this.anoNacimiento = 1900;
            this.telefono = "0000000000";
        }

        public String DNI
        {
            get {
                if (this.dni.Length>9)
                {
                    return this.dni;
                }
                else
                {
                    return "9999999999";
                }
            }
            set
            {
                if (value.Length>9)
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = "999999999";
                }

            }
        }

        public String Nombre
        {
            get
            {
                if (this.nombre.Length>0)
                {
                    return this.nombre;
                }
                else
                {
                    return "NA";
                }
            }
            set
            {
                if (value.Length>0)
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "NA";
                }
            }
        }

        public String Correo
        {
            get
            {
                if (this.correo.Length>4)
                {
                    return this.correo;
                }
                else
                {
                    return "na@na.com";
                }
            }
            set
            {
                if (value.Length>4)
                {
                    this.correo = value;
                }
                else
                {
                    this.correo = "na@na.com";
                }
            }
        }

        public int AnoNacimiento
        {
            get
            {
                if (this.anoNacimiento>1900)
                {
                    return this.anoNacimiento;
                }
                else
                {
                    return 1900;
                }
            }
            set
            {
                if (value>1900)
                {
                    this.anoNacimiento = value;
                }
                else
                {
                    this.anoNacimiento = 1900;
                }
            }
        }
    
    public String Telefono
        {
            get
            {
                if (this.telefono.Length>9)
                {
                    return this.telefono;
                }
                else
                {
                    return "0000000000";
                }
            }
            set
            {
                if (value.Length>9)
                {
                    this.telefono = value;
                }
                else
                {
                    this.telefono = "0000000000";
                }
            }
        }
    
    }
}
