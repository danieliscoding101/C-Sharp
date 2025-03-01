using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Ahorros : Form
    {
        ClaseAhorros cA;
        public Ahorros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cA = new ClaseAhorros(txtDni.Text, txtDni.Text,
                txtNombre.Text,
                txtnumCuenta.Text, 
                Convert.ToInt32(txtAnio.Text));
            cA.Mostrar(DataGridView);
        }
    }
}
