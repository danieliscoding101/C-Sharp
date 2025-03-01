using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Usamos una liberría nueva
using System.IO;
using System.Windows.Forms;

namespace BasesDeDatos
{
    class Archivos
    {
        public void Guardar(Agenda a1)
        {
            string ruta = @"c:\MisDatos\Agenda.txt";

            using (StreamWriter myLogs = File.AppendText(ruta))
            {
                myLogs.WriteLine(a1.DNI + ";" +
                    a1.Nombre + ";" +
                    a1.Correo + ";" +
                    a1.AnoNacimiento + ";" +
                    a1.Telefono);
                myLogs.Close();
            }

        }
    
    public void LeerDatos(DataGridView grilla)
        {
            if (grilla.RowCount>0)
            {
                grilla.Rows.Clear();
            }
            string ruta = @"c:\MisDatos\Agenda.txt";

            using(StreamReader file = new StreamReader(ruta))
            {
                string linea = "";
                while ((linea = file.ReadLine()) != null)
                {
                    Char delimiter = ';';
                    string[] datos = linea.Split(delimiter);

                    string[] row = new string[]
                    {
                        datos[0],
                        datos[1],
                        datos[2],
                        datos[3],
                        datos[4]
                    };
                    grilla.Rows.Add(row);


                }
                file.Close();
            }



        }    
    }

}
