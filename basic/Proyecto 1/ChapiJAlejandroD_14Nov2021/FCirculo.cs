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
    public partial class FCirculo : Form
    {
        public FCirculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Circulo cp = new Circulo(Convert.ToDouble(txtRadio.Text));
            cp.MostrarDatos(dataGridView);
        }
    }
}
