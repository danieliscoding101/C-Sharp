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
    public partial class FTrapecioIso : Form
    {
        public FTrapecioIso()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Trapecio cp = new Trapecio(Convert.ToDouble(txtBaseMayor.Text), 
                Convert.ToDouble(txtBaseMayor.Text), 
                Convert.ToDouble(txtAlto.Text),
                Convert.ToDouble(txtLado.Text), 
                Convert.ToDouble(txtProf.Text));
            cp.MostrarDatos(dataGridView);
        }
    }
}
