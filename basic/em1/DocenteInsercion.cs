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
    public partial class DocenteInsercion : Form
    {
        Docente[] arrayDocente;
        Docente d1 = new Docente();
        int i = 0;
        public DocenteInsercion()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            d1.insercion(arrayDocente);
            d1.iMostrar(datosDocenteOrd, arrayDocente);
        }

        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDimensionar.Text) > 0)
            {
                arrayDocente = new Docente[Convert.ToInt32(txtDimensionar.Text)];
                btnCalcular.Enabled = true;
                btnDimensionar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Arreglo mal dimensionado");
                txtDimensionar.Text = "0";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                arrayDocente[i] = new Docente(Convert.ToDouble(txtSueldo.Text), cbnTitulo.Text,
                    cbnTipoContrato.Text, txtDni.Text, txtNombre.Text,
                    Convert.ToInt32(txtAnoNacimiento.Text), txtCorreo.Text);
                i++;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("El vector está lleno");
                btnCalcular.Enabled = false;
                btnMostrar.Enabled = true;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            d1.iMostrar(datosUsuario, arrayDocente);
            btnOrdenar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string respuesta = "Sueldo no encontrado";
            respuesta = d1.Busquedasecuencial(arrayDocente, Convert.ToDouble(txtDato.Text));
            MessageBox.Show("" + respuesta);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datosUsuario.Rows.RemoveAt(Convert.ToInt32(txtEliminar.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("La posición especificada no existe, vuelva a intentar");

            }
        }
    }
}
