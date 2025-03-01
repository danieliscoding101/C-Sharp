using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructores
{
    public partial class Form1 : Form
    {
        Docente d1;
        public Form1()
        {
            InitializeComponent();
            d1 = new Docente();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            d1.Nombre = txtNombre.Text;
            d1.NumeroHijos = Convert.ToInt32(txtDNI.Text);
            d1.Sueldo = Convert.ToDouble(txtSueldo.Text);
            d1.NumeroHijos = Convert.ToInt32(txtNumHijos.Text);
            MessageBox.Show(d1.Nombre);

           // d1.NumeroHijos = Convert.ToInt32(txtDNI.Text);
            //MessageBox.Show(Convert.ToString(d1.NumeroHijos));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
