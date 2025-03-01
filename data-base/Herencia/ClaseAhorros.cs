using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    class ClaseAhorros : ClasePrincipal
    {
        private double CalcularInteres()
        {
            return 0;
        }
        public void Mostrar(DataGridView grilla)
        {
            string[] row = new string[]
            {
                this.Dni,
                this.NombreCliente,
                this.NroCuenta,
                Convert.ToString(this.AnoNacimiento),
                this.NroLibreta
            };
            grilla.Rows.Add(row);
        }

        public ClaseAhorros(string nroLibreta, 
            string dni, 
            string nombreCliente,
            string nroCuenta, 
            int anoNacimiento) : base (dni, nombreCliente, nroCuenta, anoNacimiento)
        {
            NroLibreta = nroLibreta;
        }

        private String NroLibreta;
    }
}
