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
    public partial class MenuEstudiante : Form
    {
        public MenuEstudiante()
        {
            InitializeComponent();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmEstudiante();
            formulario.Show();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            Form formulario = new EstudianteShell();
            formulario.Show();
        }

        private void btnInsercion_Click(object sender, EventArgs e)
        {
            Form formulario = new EstudianteInsercion();
            formulario.Show();
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            Form formulario = new EstudianteHeapsort();
            formulario.Show();
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            Form formulario = new EstudianteMergeSort();
            formulario.Show();
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            Form formulario = new EstudianteQuickSort();
            formulario.Show();
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmEstudiante();
            formulario.Show();
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmEstudiante();
            formulario.Show();
        }
    }
}
