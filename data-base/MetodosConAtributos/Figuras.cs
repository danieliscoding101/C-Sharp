using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase19_11_MetodosConAtributos
{
    class Figuras
    {
        

        //Cuadrado

        private int CalcularPerimetro(int lado)
        {
            return lado * 4;
        }
        private int CalcularArea(int lado)
        {
            return lado*lado;
        }
        
        private int CalcularVolumen(int lado)
        {
            return lado * lado * lado;
        }

        //Rectángulo

        private int CalcularPerimetro(int lado, int lado2)
        {
            return lado*2+lado2*2;
        }

        private int CalcularArea(int lado1, int lado2)
        {
            return lado1*lado2;
        }
        private int CalcularVolumen(int lado, int lado2)
        {
            return lado * lado2 * lado2;
        }
        //Triangulo
        private double CalcularPerimetro(int base1, int altrura, int b=3)
        {
            return base1*3;
        }
        private double CalcularArea(int base1, int altura, int a=2)
        {
            return base1*altura/2;
        }

        private int CalcularVolumen(int base1, int base2, int base3)
        {
            return lado * lado * lado;
        }
        //Circulo
        
        //Hexagono
        public void MostrarDatos(DataGridView grilla, int fig)
        {
            if (fig == 0)
            {
                string[] row = new string[]
                {
                        Convert.ToString(CalcularPerimetro(this.lado)),
                        Convert.ToString(CalcularArea(this.lado)),
                        Convert.ToString(CalcularVolumen(this.lado))
                    };
                    grilla.Rows.Add(row);
                } else if(fig == 1)
                        {
                            string[] row = new string[]
                            {
                            Convert.ToString(CalcularPerimetro(this.lado, this.lado2)),
                            Convert.ToString(CalcularArea(this.lado, this.lado2)),
                            Convert.ToString(CalcularVolumen(this.lado, this.lado2))
                            };
                            grilla.Rows.Add(row);
                        }
            else if (fig == 2)
            {
                string[] row = new string[]
                {
                            Convert.ToString(CalcularPerimetro(this.lado, this.lado2)),
                            Convert.ToString(CalcularArea(this.lado, this.lado2)),
                            Convert.ToString(CalcularVolumen(this.lado, this.lado2))
                };
                grilla.Rows.Add(row);
            }
            else if (fig == 3)
            {
                string[] row = new string[]
                {
                            Convert.ToString(CalcularPerimetro(this.lado)),
                            Convert.ToString(CalcularArea(this.lado)),
                            Convert.ToString(CalcularVolumen(this.lado))
                };
                grilla.Rows.Add(row);
            }
            else if (fig == 4)
            {
                string[] row = new string[]
                {
                            Convert.ToString(CalcularPerimetro(this.lado, this.lado2)),
                            Convert.ToString(CalcularArea(this.lado, this.lado2)),
                            Convert.ToString(CalcularVolumen(this.lado, this.lado2))
                };
                grilla.Rows.Add(row);
            }

        }

        public Figuras(int lado)
        {
            //Cuadrado
            this.lado = lado;
        }

        public Figuras(int lado, int lado2) : this(lado)
        {
            //Rectangulo
            this.lado2 = lado2;
        }

        public Figuras(int base1, int altura, int b=4)
        {
            //
            this.baseT = base1;
            this.alturaT = altura;
        }

        public Figuras(int radio, int b = 8, int c= 5, int d= 9)
        {
            this.radio = radio;
        }
        public Figuras (int ladoH, int ap, int v=5, int r =4, int t = 6)
        {
            this.ladoH = ladoH;
            this.ap = ap;
        }

        private int lado;
        private int lado2;
        private int baseT;
        private int alturaT;
        private int radio;
        private int ladoH;
        private int ap;
    }

}
