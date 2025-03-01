using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasesDeDatos
{
    public partial class Form1 : Form
    {
        Agenda a1 = new Agenda();
        Archivos arch = new Archivos();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            a1.DNI = txtDni.Text;
            a1.Nombre = txtNombre.Text;
            a1.Correo = txtCorreo.Text;
            a1.AnoNacimiento = Convert.ToInt32(txtAnoNacimiento.Text);
            a1.Telefono = txtTelefono.Text;
            arch.Guardar(a1);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            arch.LeerDatos(datosAgenda);
        }
    }
}
