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
    public partial class FEstudiante : Form
    {
        Estudiante e1;
        public FEstudiante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            e1 = new Estudiante(Convert.ToInt32(txtNuMaterias.Text),
                txtDomicilio.Text,txtdni.Text,txtNombre.Text,
                Convert.ToInt32(txtAnioNacimiento.Text), cmbGenero.Text, txtEstadoCivil.Text);
            e1.IMostrar(datosEstudiante);
        }
    }
}
