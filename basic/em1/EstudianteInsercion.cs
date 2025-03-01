using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase11_f10_12ArreglosMetodos
{
    public partial class EstudianteInsercion : Form
    {
        Estudiante[] arrayEstudiante;
        Estudiante e1 = new Estudiante();
        int i = 0;
        public EstudianteInsercion()
        {
            InitializeComponent();
        }

        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            arrayEstudiante = new Estudiante[Convert.ToInt32(txtDimensionar.Text)];
            btnDimensionar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                arrayEstudiante[i] = new Estudiante(cmbAsignatura.Text,

                    Convert.ToDouble(txtNota1.Text),
                    Convert.ToDouble(txtNota2.Text),
                    Convert.ToInt32(cmbNivel.Text),
                    txtDni.Text,
                    txtNombre.Text,
                    Convert.ToInt32(txtAnoNacim.Text),
                    txtCorreo.Text);

                i++;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Vector lleno...");
                btnAgregar.Enabled = false;
                btnMostrar.Enabled = true;

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            e1.iMostrar(datosEstudiante, arrayEstudiante);
            btnOrdenar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            e1.insercion(arrayEstudiante);
            e1.iMostrar(datosEstudianteOrd, arrayEstudiante);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string respuesta = "Valor no encontrado";
            respuesta = e1.Busquedasecuencial(arrayEstudiante, Convert.ToInt32(txtDato.Text));
            MessageBox.Show("" + respuesta);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datosEstudiante.Rows.RemoveAt(Convert.ToInt32(txtEliminar.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("La posición especificada no existe, vuelva a intentar");

            }
        }
    }
}
