using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_09
{
    class Corriente : Cuenta
    {
        private int generarChequera()
        {
            // TODO: implement
            return 0;
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
                this.nroChequera
            };
            grilla.Rows.Add(row);
        }

        private String nroChequera;

        public Corriente(string nroChequera, string dni, string nombreCliente, string nroCuenta, int anoNacimiento, double Saldo)
            :base(dni, nombreCliente, nroCuenta, anoNacimiento, Saldo)
        {
            this.nroChequera = nroChequera;
        }
    }
}
