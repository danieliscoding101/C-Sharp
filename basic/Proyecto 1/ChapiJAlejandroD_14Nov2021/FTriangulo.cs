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
    public partial class FTriangulo : Form
    {
        public FTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Triangulo cp = new Triangulo(Convert.ToDouble(txtAncho.Text),
                Convert.ToDouble(txtLargo.Text), Convert.ToDouble(txtAlto.Text));
            cp.MostrarDatos(dataGridView);
        }
    }
}
