using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesAbstractas
{
    class Docente : Persona, iCalculos
    {
        public void IMostrar(DataGridView grilla)
        {
            // TODO: implement
            string[] row = new string[]
            {
                this.Dni,
                this.Nombre,
                Convert.ToString(this.AnoNacimiento),
                this.Titulo,
                Convert.ToString(this.Sueldo),
                Convert.ToString(this.CalcularEdad()),
                Convert.ToString(this.CalcularIESS()),
                Convert.ToString(this.CalcularSueldo()),

            };
            grilla.Rows.Add(row);
        }

        private double CalcularIESS()
        {
            // TODO: implement
            return this.Sueldo*0.0935;
        }

        private double CalcularSueldo()
        {
            // TODO: implement
            return this.Sueldo-this.CalcularIESS();
        }

        public Docente(string titulo, double sueldo, 
            String dni, String nombre, int anoNacimiento): base(dni, nombre,anoNacimiento)
        {
            Titulo = titulo;
            Sueldo = sueldo;
        }

        private String Titulo;
        private double Sueldo;
    }
}
