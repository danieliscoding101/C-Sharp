using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_14Nov2021
{
    class Circulo
    {
        private double radio;


        //Cuadrado y rectángulo
        private double Perimetro()
        {
            return (2*(Math.PI)*radio);
        }
        private double Area()
        {
            return (Math.PI)*(radio)*(radio);
        }

        private double Volumen() { 
        
            return (Math.PI)*(Math.Pow(radio,3))*(1.33);
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

        public Circulo(double radio)
        {
            this.radio = radio;
            
        }
    }
}
