using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    class ClasePrincipal
    {
        protected double Depositar()
        {
            return 0;
        }
        protected double Retirar()
        {
            return 0;
        }
        protected double CalcularSaldo()
        {
            return 0;
        }

        protected void Mostrar(DataGridView grilla)
        {

        }

        public ClasePrincipal(string dni, string nombreCliente, string nroCuenta, int anoNacimiento)
        {
            Dni = dni;
            NombreCliente = nombreCliente;
            NroCuenta = nroCuenta;
            AnoNacimiento = anoNacimiento;
        }

        protected String Dni;
        protected String NombreCliente;
        protected String NroCuenta;
        protected int AnoNacimiento;
    }
}
