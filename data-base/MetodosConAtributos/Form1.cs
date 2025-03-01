using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase19_11_MetodosConAtributos
{
    public partial class Form1 : Form
    {
        Figuras f1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cbnFiguras.SelectedIndex == 0)
            {
                f1 = new Figuras(Convert.ToInt32(txtLado1.Text));
                
            } else if (cbnFiguras.SelectedIndex == 1)
            {
                f1 = new Figuras(Convert.ToInt32(txtLado1.Text),
                    Convert.ToInt32(txtLado2.Text));   
            }
            else if (cbnFiguras.SelectedIndex == 2)
            {
                f1 = new Figuras(Convert.ToInt32(txtBaseT.Text),
                    Convert.ToInt32(txtBaseT.Text));
            }
            else if (cbnFiguras.SelectedIndex == 3)
            {
                f1 = new Figuras(Convert.ToInt32(txtRadio.Text));
            }
            else if (cbnFiguras.SelectedIndex == 4)
            {
                f1 = new Figuras(Convert.ToInt32(txtLadoH.Text),
                    Convert.ToInt32(txtAp.Text));

            }
            f1.MostrarDatos(datosFiguras, cbnFiguras.SelectedIndex);
        }
    }
}
