using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11_f10_12ArreglosMetodos
{
    class Persona
    {



        protected String dni;
        protected String nombre;
        protected int anoNacimiento;
        protected String correo;

        public Persona()
        {
        }

        public Persona(string dni, string nombre, int anoNacimiento, string correo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.anoNacimiento = anoNacimiento;
            this.correo = correo;
        }

        protected int CalcularEdad()
        {
            return DateTime.Today.Year - this.anoNacimiento;
        }

    }
}
