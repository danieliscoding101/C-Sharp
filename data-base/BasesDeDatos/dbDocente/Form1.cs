using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDocente
{
    public partial class Form1 : Form
    {
        dbGeneral dbG = new dbGeneral();
        Docente d1;
        public Form1()
        {
            InitializeComponent();
            d1 = new Docente();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            dbG.ObtenerConexion();
            MessageBox.Show("Conectado");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            d1.DNI = txtDni.Text;
            d1.Nombre = txtNombre.Text;
            d1.Sueldo = Convert.ToDouble(txtSueldo.Text);
            d1.AnoNac = Convert.ToInt32(txtAnoNac.Text);

            int resultado= dbG.Agregar(d1);

            if (resultado > 0)
            {
                MessageBox.Show("Docente agregado con éxito", "Agregar", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al insertar los datos", "Fallo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dbG.Buscar(datosDocente);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            d1.DNI = txtDni.Text;
            d1.Nombre = txtNombre.Text;
            d1.Sueldo = Convert.ToDouble(txtSueldo.Text);
            d1.AnoNac = Convert.ToInt32(txtAnoNac.Text);
            if (dbG.Actualizar(d1)>0)
            {
                MessageBox.Show("Docente actualizado con éxito", "Agregar",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al actualizar los datos", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void datosDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDni.Text = datosDocente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = datosDocente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSueldo.Text   = datosDocente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAnoNac.Text = datosDocente.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar el registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (dbG.Eliminar(txtDni.Text)>0)
                {
                    MessageBox.Show("Docente eliminado con éxito", "Agregar",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al eliminar los datos", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Accion Cancelada", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
         
        }
    }
}
