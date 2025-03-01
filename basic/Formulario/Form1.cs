using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_12Nov2021
{
    public partial class Form1 : Form
    {
        IMC calculo;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo = new IMC(txtDNI.Text, txtNombre.Text, Convert.ToInt32(txtAnio.Text),
                Convert.ToString(cbnGenero.SelectedIndex==0),Convert.ToDouble(txtPeso.Text),
                Convert.ToDouble(txtAltura.Text));
            calculo.MostrarDatos(datosParaIMC);

        }
    }
}
