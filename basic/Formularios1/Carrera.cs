using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_30Nov2021
{
    class Carrera
    {
        private string Dni
        {
            set
            {
                if (this.dni.Length < 10)
                {
                    this.dni = "9999999999";
                }
                else
                {
                    this.dni = value;
                }
            }
            get
            {
                if (this.dni.Length < 10)
                {
                    return this.dni = "9999999999";
                }
                else
                {
                    return this.dni;
                }
            }
        }
        private string Nombre
        {
            set
            {
                if (this.nombre.Length<4)
                {
                    this.nombre = "Consumidor Final";
                }
                else
                {

                this.nombre = value;
                }
            }
            get
            {
                if (this.nombre.Length < 4)
                {
                    return this.nombre = "Consumidor Final";
                }
                else
                {
                    return this.nombre;
                }
                
            }
        }

        protected string CalcularEdad()
        {
            if (Convert.ToInt32(anioNacimiento) > 2021)
            {
                return "0";
            }else { 
            this.edad = 2021 - Convert.ToInt32(this.anioNacimiento);
            return Convert.ToString(this.edad);
            }
        }
        protected int CalcularPrecio()
        {
            if (this.sueldo<400)
            {
                return this.valorPagar = 200 - Convert.ToInt32(CalcularEdad());
            } else
            {
                this.valorPagar = (this.sueldo / 2) - Convert.ToInt32(CalcularEdad());
                return this.valorPagar;
            }
        }

        public void MostrarDatos(DataGridView grilla)
        {
            String[] row = new String[]
            {
                this.Dni,
                this.Nombre,
                this.CalcularEdad(),
                Convert.ToString(this.CalcularPrecio())


            };

            grilla.Rows.Add(row);
        }

        protected string dni;
        protected string nombre;
        protected string anioNacimiento;
        protected int edad;
        protected int sueldo;
        protected int valorPagar;

        public Carrera(string dni, string nombre, string anioNacimiento, int sueldo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.anioNacimiento = anioNacimiento;
            this.sueldo = sueldo;
        }
    }
}
