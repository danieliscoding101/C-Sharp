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
    public partial class portada : Form
    {
        public portada()
        {
            InitializeComponent();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            Form formularioDocente = new MenuDocente();
            formularioDocente.Show();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Form formularioDocente = new MenuEstudiante();
            formularioDocente.Show();
        }
    }
}
