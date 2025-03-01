using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_14Nov2021
{
    class Trapecio
    {
        private double baseMay;
        private double baseMen;
        private double altura;
        private double lado;
        private double profundidad;


        //Cuadrado y rectángulo
        private double Perimetro()
        {
            return this.baseMay + this.baseMen + (this.lado * 2);
        }
        private double Area()
        {
            //return ((baseMay-baseMen) * altura) / 2;
            return (baseMay+baseMen)*altura/2;
        }

        private double Volumen()
        {
            return Area() * profundidad;
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

        public Trapecio(double baseMayor, double baseMenor, double altura, double lado, double profundidad)
        {
            this.baseMay = baseMayor;
            this.baseMen = baseMenor;
            this.altura = altura;
            this.lado = lado;
            this.profundidad = profundidad;
        }
    }
}
