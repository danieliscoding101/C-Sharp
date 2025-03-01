using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_12Nov2021
{
    class IMC
    {
        //Atributos
        private string DNI;
        private string nombre;
        private int edad;
        private string genero;
        private double peso;
        private double altura;
        private double imc;
        //Métodos
        
        
        private int CalcularEdad()
        {
            int edadAnios;
            edadAnios = 2021 - this.edad;
            return edadAnios;
        }
        
        
        private string DeterminarEdad(int estadoEdad)
        {
            if (estadoEdad<18)
            {
                return "Menor de edad";
            }
            if (estadoEdad >= 18 && estadoEdad <75)
            {
                return "Mayor de edad";
            }
            if (estadoEdad >= 75) 
            {
                return "Tercera edad";
            }
            else
            {
                return "";
            }
            
        }
        private double CalcularIMC()
        {
            return this.peso/(this.altura*this.altura);
        }
        private string EstadoIMC(double iemece)
        {
            if (iemece<18.5)
            {
                return "PESO BAJO";
            }
            if (iemece >=18.5 && iemece <25)
            {
                return "IDEAL";
            }
            if (iemece >= 25 && iemece <30)
            {
                return "SOBREPESO";
            }
            if (iemece >=30 && iemece <35)
            {
                return "OBESIDAD";
            }
            if (iemece >=35 && iemece <40)
            {
                return "OBESIDAD SEVERA";
            }
            if (iemece >=40)
            {
                return "OBESIDAD MORBIDA";
            }
            
            return "";
        }
        private string MostrarGenero(string genero)
        {
            if (genero == "True")
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
        }
        public void MostrarDatos(DataGridView grilla)
        {
            string[] row = new string[]
            {
                DNI,
                nombre,
                Convert.ToString(CalcularEdad()),
                DeterminarEdad(CalcularEdad()),
                MostrarGenero(genero),
                //genero,
                Convert.ToString(CalcularIMC()),
                EstadoIMC(CalcularIMC()),
            };
            grilla.Rows.Add(row);
        }
        public IMC(string dNI, string nombre, int edad, string genero, double peso, double altura)
        {
            DNI = dNI;
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
            this.peso = peso;
            this.altura = altura;
            
        }
    }
}
