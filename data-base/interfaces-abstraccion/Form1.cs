using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_08Dic2021
{
    public partial class Form1 : Form
    {
        Docente d1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            d1 = new Docente(cmbTitulo.Text, Convert.ToDouble(txtSalario.Text), 
                txtdni.Text, txtNombre.Text, Convert.ToInt32(txtAnioNacimiento.Text), 
                cmbGenero.Text, txtEstadoCivil.Text);
            d1.IMostrar(datosUsuario);
           
            
        }

        private void btnIrEstudiantes_Click(object sender, EventArgs e)
        {
            Form estudiante = new FEstudiante();
            estudiante.Show();
        }
    }
}
