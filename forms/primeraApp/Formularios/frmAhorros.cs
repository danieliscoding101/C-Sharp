using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_09
{
    public partial class frmAhorros : Form
    {
        Ahorros a1;
        public frmAhorros()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            a1 = new Ahorros(txtNumeroLibreta.Text,
             txtDni.Text,
             txtNombre.Text,
             txtCuenta.Text,
             Convert.ToInt32(txtAñoNacimiento.Text), 
             Convert.ToDouble(txtDepositar.Text));
            a1.Mostrar(DatosAhorros);
        }
    }
}
