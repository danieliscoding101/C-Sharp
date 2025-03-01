using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapiJAlejandroD_14Nov2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Fcuadrado();
            formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rectánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FRectangulo();
            formulario.Show();
        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FTriangulo();
            formulario.Show();
        }

        private void pentágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FPentagono();
            formulario.Show();
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FCirculo();
            formulario.Show();
        }

        private void romboToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Form formulario = new FRombo();
            //formulario.Show();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form formulario = new FTrapecioIsosceles();
            //formulario.Show();
        }

        private void trapecioIsoscelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FTrapecioIso();
            formulario.Show();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FRombo();
            formulario.Show();
        }
    }
}
