using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    abstract class Persona

        //public abstract class persona (es lo que viene de power design)
    {

        protected int CalcularEdad()
        {

            // TODO: implement
            return DateTime.Today.Year - AnoNacimiento ;
        }

        protected String Dni;
        protected String Nombre;
        protected int AnoNacimiento;

        public Persona(string dni, string nombre, int anoNacimiento)
        {
            Dni = dni;
            Nombre = nombre;
            AnoNacimiento = anoNacimiento;
        }
    }
}
