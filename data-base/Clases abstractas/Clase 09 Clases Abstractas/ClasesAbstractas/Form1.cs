using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesAbstractas
{
    public partial class Form1 : Form
    {
        Docente d1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Docente d1 = new Docente(cbnTitulo.SelectedItem.ToString(), //opcion cbnTitulo.Text
                Convert.ToDouble(txtSueldo.Text),
                txtDni.Text,
                txtNombre.Text,
                Convert.ToInt32(txtAnoNacimiento.Text)
                );
            d1.IMostrar(datosDocente);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
