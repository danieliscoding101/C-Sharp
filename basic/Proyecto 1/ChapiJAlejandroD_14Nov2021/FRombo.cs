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
    public partial class FRombo : Form
    {
        public FRombo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Rombo cp = new Rombo(Convert.ToDouble(txtDiagMayor.Text), 
                Convert.ToDouble(txtDiagMenor.Text), Convert.ToDouble(txtProf.Text));
            cp.MostrarDatos(dataGridView);
        }
    }
}
