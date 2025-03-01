using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_09
{
    class Ahorros : Cuenta
    {
        
        private double calcularAhorros()
        {
            TotalAhorros = SaldoInicAhorros + this.saldo;
            SaldoInicAhorros = TotalAhorros;
            TotalAhorros = 0;
            return SaldoInicAhorros;
        }
        public void Mostrar(DataGridView grilla)
        {
            // TODO: implement
            string[] row = new string[]
            {
                this.dni,
                this.nombreCliente,
                this.nroCuenta,
                Convert.ToString(this.anoNacimiento),
                this.nroLibreta,
                Convert.ToString(this.calcularAhorros())

            };
            grilla.Rows.Add(row);
        }

        private String nroLibreta;
        public double TotalAhorros;
        public double SaldoInicAhorros;

        public Ahorros(string nroLibreta, string dni, string nombreCliente, string nroCuenta, int anoNacimiento, double saldo)
            : base(dni, nombreCliente, nroCuenta, anoNacimiento, saldo)
        {
            this.nroLibreta = nroLibreta;
            //this.SaldoInicAhorros = saldo;
        }
    }
}
