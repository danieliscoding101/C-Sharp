using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_14Nov2021
{
    class Triangulo
    {
        private double largo;
        private double ancho;
        private double alto;
        
        //Cuadrado y rectángulo
        private double Perimetro()
        {
            double hp1, hp2;
            hp1 = Math.Sqrt(((largo/2)* (largo / 2))+(alto*alto));
            hp2 = Math.Sqrt((hp1*hp1)+(ancho/2)*(ancho/2));
            return hp2+hp2+ancho;
        }
        private double Area()
        {
            double hp1, hp2;
            hp1 = Math.Sqrt(((largo / 2) * (largo / 2)) + (alto * alto));
            hp2 = Math.Sqrt((hp1 * hp1) + (ancho / 2) * (ancho / 2));
            
            return (ancho*hp1)/2;
        }

        private double Volumen()
        {
            return this.ancho * this.largo * this.alto;
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

            public Triangulo(double largo, double ancho, double altura)
        {
            this.largo= largo;
            this.ancho = ancho;
            this.alto = altura;
        }
    }
}
