using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapiJAlejandroD_08Dic2021
{
    public abstract class Persona
    {
        protected int CalcularEdad()
        {
            return 2021-this.anioNacimiento;
        }
        
        protected string dni;
        protected string nombre;
        protected int anioNacimiento;
        protected string genero;
        protected string estadoCivil;
        

        public Persona(string dni, string nombre, int AnioNacimiento, string genero, string estadoCivil)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.anioNacimiento = AnioNacimiento;
            this.genero = genero;
            this.estadoCivil = estadoCivil;
        }
    }
}
