using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dbDocente
{
    class dbGeneral
    {

        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server= 127.0.0.1; database=Prueba; Uid=root; pwd=;");
            try
            {
                conectar.Open();

            }
            catch(Exception)
            {
                MessageBox.Show("Error al conectar con la DB");
            }
            return conectar;
        }

        public int Agregar(Docente d)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(String.Format("Insert into docente(DNI, Nombre, Sueldo, AnoNac) values ('{0}','{1}','{2}','{3}')",
                    d.DNI, d.Nombre, d.Sueldo, d.AnoNac), this.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {

                return -1;
            }
        }
        public void Buscar(DataGridView grilla)
        {
            if (grilla.Rows.Count > 0)
            {
                grilla.Rows.Clear();
            }
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * from docente"), 
                    this.ObtenerConexion());
                MySqlDataReader leer = comando.ExecuteReader();
                Docente d = new Docente();
                while (leer.Read())
                {
                    d.DNI = leer.GetString(0);
                    d.Nombre = leer.GetString(1);
                    d.Sueldo = leer.GetDouble(2);
                    d.AnoNac = leer.GetInt32(3);
                    string[] rows = new string[]
                    {
                        d.DNI,
                        d.Nombre,
                        Convert.ToString(d.Sueldo),
                        Convert.ToString(d.AnoNac)
                    };
                    grilla.Rows.Add(rows);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al listar los docentes...");
                
            }
        }
        public int Actualizar(Docente d)
        {
            int retorno = 0;
            MySqlConnection conexion = this.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Update docente set " +
                "Nombre = '{0}' , " +
                "Sueldo = '{1}' ," +
                "anoNac = '{2}' " +
                " Where DNI= '{3}'",
                d.Nombre, d.Sueldo, d.AnoNac, d.DNI), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }
        public int Eliminar(String pDNI)
        {
            int retorno = 0;
            MySqlConnection conexion = this.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Delete From docente " +
                "Where DNI= '{0}'", pDNI), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
