using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_14Nov2021
{
    public partial class FRectangulo : Form
    {
        public FRectangulo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Rectangulo cp = new Rectangulo(Convert.ToDouble(txtBase1.Text),
                Convert.ToDouble(txtAltura.Text), Convert.ToDouble(txtProfundidad.Text));
            cp.MostrarDatos(dataGridView);
        }
    }
}
