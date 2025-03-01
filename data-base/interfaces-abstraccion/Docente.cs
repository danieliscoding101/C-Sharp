using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_08Dic2021
{
    class Docente: Persona, iMostrar
    {

        private string Dni
        {
            set
            {
                if (value.Length > 9)
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = "123456789";
                }
            }
            get
            {
                if (this.dni.Length > 9)
                {
                    return this.dni;
                }
                else
                {
                    return "99999999999";
                }
            }
        }
        private string Nombre
        {
            set
            {
                if (value.Length > 3)
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "Consumidor Final";
                }
            }
            get
            {
                if (this.nombre.Length > 3)
                {
                    return this.nombre;
                }
                else
                {
                    return "Consumidor Final";
                }
            }
        }
        private string Titulo
        {
            set
            {
                if (value.Length > 2)
                {
                    this.titulo = value;
                }
                else
                {
                    this.titulo = "Ninguno";
                }
            }
            get
            {
                if (this.titulo.Length > 2)
                {
                    return this.titulo;
                }
                else
                {
                    return "Ninguno";
                }
            }
        }
        private string Genero
        {
            set
            {
                if (value.Length !=0)
                {
                    this.genero = value;
                }
                else
                {
                    this.genero = "NA";
                }
            }
            get
            {
                if (this.genero.Length !=0)
                {
                    return this.nombre;
                }
                else
                {
                    return "NA";
                }
            }
        }

        private string EstadoCivil
        {
            set
            {
                if (value.Length !=0)
                {
                    this.estadoCivil = value;
                }
                else
                {
                    this.estadoCivil = "NA";
                }
            }
            get
            {
                if (this.estadoCivil.Length !=0)
                {
                    return this.estadoCivil;
                }
                else
                {
                    return "NA";
                }
            }
        }
        public void IMostrar(DataGridView grilla)
        {
            //MessageBox.Show(this.dni);
            string[] row = new string[]
            {
                this.Dni,
                this.Nombre,
                this.Titulo,
                this.Genero,
                this.EstadoCivil,
                Convert.ToString(this.CalcularEdad()),
                Convert.ToString(this.CalcularIESS()),
                Convert.ToString(this.CalcularSueldo())
            };
            grilla.Rows.Add(row);
           // MessageBox.Show(this.dni);
        }
        
        private double CalcularIESS()
        {
            return this.salario * 0.0935;
        }

        private double CalcularSueldo()
        {
            return this.salario - CalcularIESS();
        }

        protected string titulo;
        protected double salario;
        

        public Docente(string titulo, double salario, 
            string dni, string nombre, int AnioNacimiento, string genero, string estadoCivil) : 
            base(dni, nombre, AnioNacimiento, genero, estadoCivil)
        {
            this.titulo = titulo;
            this.salario = salario;
        }
    }
}
