using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_14Nov2021
{
    class Cuadrado
    {
        private double base1;
        private double altura;
        private double profundidad;


        //Cuadrado y rectángulo
        private double Perimetro()
        {
            return (this.base1 * 2) + (this.altura * 2);
        }
        private double Area()
        {
            return this.base1 * this.altura;
        }

        private double Volumen()
        {
            return this.base1 * this.altura * this.profundidad;
        }

        public void MostrarDatos(DataGridView grilla)
        {
            string[] row = new string[]
            {
                Convert.ToString(Perimetro()),
                Convert.ToString(Area()),
                Convert.ToString(Volumen())
            };
            grilla.Rows.Add(row);
        }

        public Cuadrado(double largo, double ancho, double profundidad)
        {
            this.base1 = largo;
            this.altura = ancho;
            this.profundidad = profundidad;
        }
    }
}
