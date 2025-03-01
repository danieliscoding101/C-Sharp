using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_09.Formularios
{
    public partial class frmCorriente : Form
    {
        Corriente a1;
        public frmCorriente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            a1 = new Corriente(txtNumeroChequera.Text,
           txtDni.Text,
           txtNombre.Text,
           txtCuenta.Text,
           Convert.ToInt32(txtAñoNacimiento.Text),
           Convert.ToDouble(Text));
            a1.Mostrar(DatosCorriente);
        }
    }
}
