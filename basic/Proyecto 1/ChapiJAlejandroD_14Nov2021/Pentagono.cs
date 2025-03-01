using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_14Nov2021
{
    class Pentagono
    {
        private double lado;
        private double alto;
        


        //Cuadrado y rectángulo
        private double Perimetro()
        {
            return (this.lado * 5);
        }
        private double Area()
        {
            double ap = (lado / (2*(Math.Tan((Math.PI)/5))));
            return (Perimetro()*ap)/2;
        }

        private double Volumen()
        {
            return Area()*alto;
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

        public Pentagono(double largo, double alto)
        {
            this.lado = largo;
            this.alto = alto;
           
        }
    
}
}
