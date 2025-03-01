using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_09
{
    class Cuenta
    {
        public double Saldo
        {
            set{

                //this.saldo =value;
                //saldoInicial = this.saldo;
            }
            get
            {
                return 0;
            }
        }
        protected double Depositar()
        {
            //public double saldoInicial;
            Total = saldoInicial + this.saldo;
            saldoInicial = Total;
            Total = 0;
            //saldoInicial= saldoInicial + this.saldo;

            //saldoInicial = this.saldo;
            return this.saldoInicial;
        }

        protected double Retirar()
        {
            // TODO: implement
            return 0.0;
        }

        protected double CalcularSaldo()
        {
            // TODO: implement
            return 0.0;
        }

        protected void Mostrar(DataGridView grilla)
        {
            // TODO: implement
        }

        protected String dni;
        protected String nombreCliente;
        protected String nroCuenta;
        protected int anoNacimiento;
        public double saldo;
        public double saldoInicial;
        public double Total;

        public Cuenta(string dni, string nombreCliente, string nroCuenta, int anoNacimiento, double saldo)
        {
            this.dni = dni;
            this.nombreCliente = nombreCliente;
            this.nroCuenta = nroCuenta;
            this.anoNacimiento = anoNacimiento;
            this.saldo = saldo;
        }
    }
}
