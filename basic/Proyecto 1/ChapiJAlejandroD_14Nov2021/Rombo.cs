using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_14Nov2021
{
    class Rombo
    {
        private double dMayor;
        private double dMenor;
        private double prof;


        //Cuadrado y rectángulo
        private double Perimetro()
        {
            double a;
            a = Math.Sqrt(((dMayor*dMayor)+(dMenor*dMenor))/4);

            return 4*a;
        }
        private double Area()
        {
            return (dMayor*dMenor)/2;
        }

        private double Volumen()
        {
            return Area()*prof;
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

        public Rombo(double DiagMayor, double DiagMenor, double prof)
        {
            this.dMayor = DiagMayor;
            this.dMenor = DiagMenor;
            this.prof = prof;
        }
    }
}
