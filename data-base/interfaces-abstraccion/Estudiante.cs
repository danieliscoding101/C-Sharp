using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_08Dic2021
{
    class Estudiante : Persona, iMostrar
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

        private string Genero
        {
            set
            {
                if (value.Length != 0)
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
                if (this.genero.Length != 0)
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
                if (value.Length != 0)
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
                if (this.estadoCivil.Length != 0)
                {
                    return this.estadoCivil;
                }
                else
                {
                    return "NA";
                }
            }
        }
        private string Domicilio
        {
            set
            {
                if (value.Length != 0)
                {
                    this.domicilio = value;
                }
                else
                {
                    this.domicilio = "NA";
                }
            }
            get
            {
                if (this.domicilio.Length != 0)
                {
                    return this.domicilio;
                }
                else
                {
                    return "NA";
                }
            }
        }
        public void IMostrar(DataGridView grilla)
        {
            
            
            
            
            string[] row = new string[]
            {
                this.Dni,
                this.Nombre,
                Convert.ToString(this.nuMaterias),
                Convert.ToString(this.CalcularEdad()),
                this.Domicilio,
                this.Genero,
                this.EstadoCivil
                
                
                

            };
            grilla.Rows.Add(row);
        }

        protected int nuMaterias;
        protected string domicilio;


        public Estudiante(int nuMaterias, string domicilio, 
            string dni, string nombre, int AnioNacimiento, string genero, string estadoCivil) :
            base(dni, nombre, AnioNacimiento, genero, estadoCivil)
        {
            this.nuMaterias = nuMaterias;
            this.domicilio = domicilio;

        }
    }
}

