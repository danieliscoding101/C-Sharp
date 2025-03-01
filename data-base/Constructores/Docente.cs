using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructores
{
    class Docente
    {
        private String dni, nombre;
        private double sueldo;
        private int numeroHijos;
    
        public String Dni
        {
            get{
                if(dni.Length > 9)
                {
                    return this.dni;
                }
                else
                {
                return "na";
                }
            }
            set {
                
                    if (value.Length > 9)
                    {
                        this.nombre = value;
                    }
                    else
                    {
                        this.nombre = "na";
                    }
                

            }
            
        }
        public String Nombre
        {
            get
            {
                if (this.nombre.Length > 9)
                {
                    return this.nombre;
                }
                else
                {
                    return "na";
                }
            }
            set
            {
                if (value.Length>0)
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "na";
                }
            }
        }
        public double Sueldo
        {
            get
            {
                return 0;
            }
            set
            {
                this.sueldo = value;
            }
        }
        
        
        public int NumeroHijos
        {
            get
            {
                if (this.numeroHijos >= 0)
                {
                    return this.numeroHijos;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value >= 0)
                {
                    this.numeroHijos = value;
                }
                else
                {
                    this.numeroHijos = 0;
                }
            }
        }
        private double CalcularIESS()
        {
            return this.Sueldo * 0.0935;
        }
        private double CalcularSueldo()
        {
            return this.Sueldo - this.CalcularIESS();
        }
        public void Mostrar(DataGridView grilla)
        {
            string[] row = new string[]
            {
                this.dni,
                this.nombre,
                Convert.ToString(this.sueldo),
                Convert.ToString(this.numeroHijos),
                Convert.ToString(this.CalcularIESS()),
                Convert.ToString(this.CalcularSueldo())
            };
            grilla.Rows.Add(row);
        }

    }

    
}
