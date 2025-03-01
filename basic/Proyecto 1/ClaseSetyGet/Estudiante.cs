using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseSetyGet
{
    class Estudiante
    {
        private string nombre;
        private string dni;
        private int nivel;
        private double nota1;
        private double nota2;
        private double promedio;




        public string DNI
        {
            get
            {
                return "";
            }
            set
            {

            }

        }
        public string Nombre
        {
            set
            {
                if (this.nombre.Length>0)
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "na";
                }
            }
            get
            {
                if (true)
                {
                    return this.nombre;
                }
                else
                {

                return nombre;
                }
            }
        }
        public double Nota1
        {
            get
            {
                if ((this.nota1>=0) && (this.nota1 <=10))
                {
                    return this.nota1;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if ((value >=0) && (value <=10))
                {
                    this.nota1 = value;
                }
                else
                {
                    this.nota1 = 0;
                }

            }
        }
        public double Nota2
        {
            get
            {
                if ((this.nota2 >= 0) && (this.nota2 <= 10))
                {
                    return this.nota2;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if ((value >= 0) && (value <= 10))
                {
                    this.nota2 = value;
                }
                else
                {
                    this.nota2 = 0;
                }

            }
        }
        public int Nivel
        {
            get
            {

                if ((this.nivel>0) && (this.nivel<9))
                {
                    return this.nivel;
                }
                else
                {
                    return 1;
                }
            }
            set{
                if ((value >0) && (value <9))
                {
                    this.nivel = value;
                }
                else
                {
                    this.nivel = 1;
                }

            }
        }
        private double Suma()
        {
            return this.nota1+this.nota2;
        }
        private double Promedio()
        {
            return Suma() / 2;
        }

        public void mostrar(DataGridView grilla)
        {
            string[] row = new string[]
            {
                this.DNI,
                this.Nombre,
                Convert.ToString(this.Nivel),
                Convert.ToString(this.Nota1),
                Convert.ToString(this.Nota2),
                Convert.ToString(this.Suma()),
                Convert.ToString(this.Promedio())
            };
            grilla.Rows.Add(row);
        }


    }
}
