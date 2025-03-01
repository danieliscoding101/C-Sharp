using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_30Nov2021
{
    public partial class Form1 : Form
    {

        Carrera pA;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            pA = new Carrera(txtDNI.Text, txtNombre.Text,txtAnio.Text,Convert.ToInt32(txtSueldo.Text));
            pA.MostrarDatos(datosCorredor);
        }
        
    }
}
