using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseSetyGet
{
    public partial class Form1 : Form
    {
        Estudiante e1;
        public Form1()
        {
            InitializeComponent();
            e1 = new Estudiante();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            e1.DNI = txtDni.Text;
            e1.Nombre = txtNombre.Text;
            e1.Nivel = Convert.ToInt32(cbnNivel.SelectedItem.ToString());
            e1.Nota1 = Convert.ToDouble(txtNota1.Text);
            e1.Nota2 = Convert.ToDouble(txtNota2.Text);
            e1.mostrar(datosEstudiante);
        }
    }
}
