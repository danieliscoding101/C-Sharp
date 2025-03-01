using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase11_f10_12ArreglosMetodos
{
    class Estudiante : Persona, iCalculosE
    {
        private String asignatura;
        private double nota1;
        private double nota2;
        private int nivel;

        public Estudiante()
        {
        }
        public Estudiante(string asignatura, double nota1,
            double nota2, int nivel, string dni, string nombre,
            int anoNacimiento, string correo)
            : base(dni, nombre, anoNacimiento, correo)
        {
            this.asignatura = asignatura;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nivel = nivel;
        }

        private double CalcularSuma()
        {
            return this.nota1 + this.nota2;
        }
        private double CalcularPromedio()
        {
            return this.CalcularSuma() / 2;
        }
        //Impelentamos la función que se encuentra en la interfaz estudiante
        //creamos una nueva interfaz para evitar errores de la interfaz Docente
        public void iMostrar(DataGridView grilla, Estudiante[] arrayEstudiante)
        {
            for (int i = 0; i < arrayEstudiante.Length; i++)
            {
                string[] row = new string[]
                {
                    Convert.ToString(i),
                    arrayEstudiante[i].dni,
                    arrayEstudiante[i].nombre,
                    Convert.ToString(arrayEstudiante[i].anoNacimiento),
                    arrayEstudiante[i].correo,
                    arrayEstudiante[i].asignatura,
                    Convert.ToString(arrayEstudiante[i].nivel),
                    Convert.ToString(arrayEstudiante[i].nota1),
                    Convert.ToString(arrayEstudiante[i].nota2),
                    Convert.ToString(arrayEstudiante[i].CalcularPromedio()),

                };
                grilla.Rows.Add(row);


            }
        }
        //METODOS DE ORDENAMIENTO


        //Metodo shell
        public Estudiante[] shellSort(Estudiante[] A)
        {
            int salto, i;
            Estudiante aux;
            bool cambios;
            for (salto = A.Length / 2; salto != 0; salto /= 2)
            {
                cambios = true;
                while (cambios)
                {
                    cambios = false;
                    for (i = salto; i < A.Length; i++)
                    {
                        if (A[i - salto].nota1 > A[i].nota1)
                        {
                            aux = A[i];
                            A[i] = A[i - salto];
                            A[i - salto] = aux;
                            cambios = true;
                        }
                    }
                }
            }
            return A;
        }
        //Método Inserción
        public Estudiante[] insercion(Estudiante[] vectorFig)
        {
            int p, j;
            Estudiante aux;
            for (p = 1; p < vectorFig.Length; p++)
            {
                aux = vectorFig[p];
                j = p - 1;
                while ((j >= 0) && (aux.nota1 < vectorFig[j].nota1))
                {
                    vectorFig[j + 1] = vectorFig[j];
                    j--;
                }
                vectorFig[j + 1] = aux;
            }
            return vectorFig;
        }
        //Metodo HeapSort
        public Estudiante[] OrdenacionHeapSort(Estudiante[] v)
        {
            int N = v.Length;
            for (int nodo = N / 2; nodo >= 0; nodo--)
            {
                HeapSort(v, nodo, N - 1);
            }
            for (int nodo = N - 1; nodo >= 0; nodo--)
            {
                Estudiante tmp = v[0];
                v[0] = v[nodo];
                v[nodo] = tmp;
                HeapSort(v, 0, nodo - 1);
            }
            return v;
        }
        public static void HeapSort(Estudiante[] v, int nodo, int fin)
        {
            int izq = 2 * nodo + 1;
            int der = izq + 1;
            int may;
            if (izq > fin)
            {
                return;
            }
            if (der > fin)
            {
                may = izq;
            }
            else
            {
                may = v[izq].nota1 > v[der].nota1 ? izq : der;
            }
            if (v[nodo].nota1 < v[may].nota1)
            {
                Estudiante tmp = v[nodo];
                v[nodo] = v[may];
                v[may] = tmp;
                HeapSort(v, may, fin);
            }
        }
        //Metodo MergeSort
        public Estudiante[] mergesort(Estudiante[] A, int izq, int der)
        {
            if (izq < der)
            {
                int m = (izq + der) / 2;
                mergesort(A, izq, m);
                mergesort(A, m + 1, der);
                merge(A, izq, m, der);
            }
            return A;
        }
        static void merge(Estudiante[] A, int izq, int m, int der)
        {
            int i, j, k;
            Estudiante[] B = new Estudiante[A.Length];
            for (i = izq; i <= der; i++)
            {
                B[i] = A[i];
            }
            i = izq;
            j = m + 1;
            k = izq;
            while (i <= m && j <= der)
            {
                if (B[i].nota1 <= B[j].nota1)
                {
                    A[k++] = B[i++];
                }
                else
                {
                    A[k++] = B[j++];
                }
            }
            while (i <= m)
            {
                A[k++] = B[i++];
            }
        }
        //Metodo QuickSort
        public Estudiante[] quicksort(Estudiante[] A, int izq, int der)
        {
            Estudiante pivote = A[izq];
            int i = izq;
            int j = der;
            Estudiante aux;
            while (i < j)
            {
                while (A[i].nota1 <= pivote.nota1 && i < j) i++;
                while (A[j].nota1 > pivote.nota1) j--;
                if (i < j)
                {
                    aux = A[i];
                    A[i] = A[j];
                    A[j] = aux;
                }
            }
            A[izq] = A[j];
            A[j] = pivote;
            if (izq < j - 1)
                quicksort(A, izq, j - 1);
            if (j + 1 < der)
                quicksort(A, j + 1, der);
            return A;
        }
        //Metodo burbuja

        public Estudiante[] BurbujaOptimizada(Estudiante[] vectorEstudiante)
        {
            Estudiante temp;
            int cont = 0;
            for (int i = 0; i < vectorEstudiante.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vectorEstudiante[i].nota1 < vectorEstudiante[j].nota1)
                    {
                        temp = vectorEstudiante[j];
                        vectorEstudiante[j] = vectorEstudiante[i];
                        vectorEstudiante[i] = temp;
                        cont++;
                    }
                }
            }
            return vectorEstudiante;
        }
        // MÉTODOS DE BÚSQUEDA
        //BUSQUEDA SECUENCIAL
        public string Busquedasecuencial(Estudiante[] t, int r)
        {
            int pos = 0;
            string t1 = "No se encontró el valor especificado";
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].nota1 == r)
                {
                    pos = i++;
                    t1 = "El valor buscado se encuentra en la fila cuya posición es : " + pos;
                    break;
                }
            }
            return t1;
        }
        //BUSQUEDA BINARIA
        public string BinarySearch(Estudiante[] arr, int first, int last, int key)
        {
            string t = "No entro dato";
            int mid = (first + last) / 2;
            while (first <= last)
            {
                if (arr[mid].nota1 < key)
                {
                    first = mid + 1;
                }
                else if (arr[mid].nota1 == key)
                {
                    t = ("Elemento en   ") + mid;
                    break;
                }
                else
                {
                    last = mid - 1;
                }
                mid = (first + last) / 2;
            }
            if (first > last)
            {
                t = ("Elemento no encontrado   ");
            }
            return t;
        }




    }


}
