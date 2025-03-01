using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase11_f10_12ArreglosMetodos
{
    class Docente: Persona, iCalculos
    {

        private double sueldo;
        private String titulo;
        private String tipoContrato;

        public Docente()
        {
        }

        public Docente(double sueldo, string titulo, string tipoContrato, 
            string dni, string nombre, int anoNacimiento, string correo) : 
            base (dni, nombre, anoNacimiento, correo)
        {
            this.sueldo = sueldo;
            this.titulo = titulo;
            this.tipoContrato = tipoContrato;
        }
        private double CalcularIESS()
        {
            return this.sueldo * 0.0935;
        }
        private double CalcularSueldo()
        {
            return this.sueldo - this.CalcularIESS();
        }
        public void iMostrar(DataGridView grilla, Docente[] arrayDocente) {
            for (int i = 0; i < arrayDocente.Length; i++)
            {
                string[] row = new string[]
                {
                    Convert.ToString(i),
                    arrayDocente[i].dni,
                    arrayDocente[i].nombre,
                    Convert.ToString(arrayDocente[i].anoNacimiento),
                    arrayDocente[i].correo,
                    Convert.ToString(arrayDocente[i].sueldo),
                    arrayDocente[i].titulo,
                    arrayDocente[i].tipoContrato
                };
                grilla.Rows.Add(row);
            }
        }
        //METODOS DE ORDENAMIENTO


        //Metodo shell
        public Docente[] shellSort(Docente[] A)
        {
            int salto, i;
            Docente aux;
            bool cambios;
            for (salto = A.Length / 2; salto != 0; salto /= 2)
            {
                cambios = true;
                while (cambios)
                {
                    cambios = false;
                    for (i = salto; i < A.Length; i++)
                    {
                        if (A[i - salto].sueldo > A[i].sueldo)
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
        public Docente[] insercion(Docente[] vectorFig)
        {
            int p, j;
            Docente aux;
            for (p = 1; p < vectorFig.Length; p++)
            {
                aux = vectorFig[p];
                j = p - 1;
                while ((j >= 0) && (aux.sueldo < vectorFig[j].sueldo))
                {
                    vectorFig[j + 1] = vectorFig[j];
                    j--;
                }
                vectorFig[j + 1] = aux;
            }
            return vectorFig;
        }
        //Metodo HeapSort
        public Docente[] OrdenacionHeapSort(Docente[] v)
        {
            int N = v.Length;
            for (int nodo = N / 2; nodo >= 0; nodo--)
            {
                HeapSort(v, nodo, N - 1);
            }
            for (int nodo = N - 1; nodo >= 0; nodo--)
            {
                Docente tmp = v[0];
                v[0] = v[nodo];
                v[nodo] = tmp;
                HeapSort(v, 0, nodo - 1);
            }
            return v;
        }
        public static void HeapSort(Docente[] v, int nodo, int fin)
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
                may = v[izq].sueldo > v[der].sueldo ? izq : der;
            }
            if (v[nodo].sueldo < v[may].sueldo)
            {
                Docente tmp = v[nodo];
                v[nodo] = v[may];
                v[may] = tmp;
                HeapSort(v, may, fin);
            }
        }
        //Metodo MergeSort
        public Docente[] mergesort(Docente[] A, int izq, int der)
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
        static void merge(Docente[] A, int izq, int m, int der)
        {
            int i, j, k;
            Docente[] B = new Docente[A.Length];
            for (i = izq; i <= der; i++)
            {
                B[i] = A[i];
            }
            i = izq;
            j = m + 1;
            k = izq;
            while (i <= m && j <= der)
            {
                if (B[i].sueldo <= B[j].sueldo)
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
        public Docente[] quicksort(Docente[] A, int izq, int der)
        {
            Docente pivote = A[izq];
            int i = izq;
            int j = der;
            Docente aux;
            while (i < j)
            {
                while (A[i].sueldo <= pivote.sueldo && i < j) i++;
                while (A[j].sueldo > pivote.sueldo) j--;
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

        public Docente[] BurbujaOptimizada(Docente[] vectorDocente)
        {
            Docente temp;
            int cont = 0;
            for (int i = 0; i < vectorDocente.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vectorDocente[i].sueldo < vectorDocente[j].sueldo)
                    {
                        temp = vectorDocente[j];
                        vectorDocente[j] = vectorDocente[i];
                        vectorDocente[i] = temp;
                        cont++;
                    }
                }
            }
            return vectorDocente;
        }
        // MÉTODOS DE BÚSQUEDA
        //BUSQUEDA SECUENCIAL
        public string Busquedasecuencial(Docente[] t, double r)
        {
            double pos = 0;
            string t1 = "No se encontró el valor especificado";
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].sueldo == r)
                {
                    pos = i++;
                    t1 = "El valor buscado se encuentra en la fila cuya posición es : " + pos;
                    break;
                }
            }
            return t1;


        }
        //BUSQUEDA BINARIA
        public string BinarySearch(Docente[] arr, int first, int last, int key)
        {
            string t = "No entro dato";
            int mid = (first + last) / 2;
            while (first <= last)
            {
                if (arr[mid].sueldo < key)
                {
                    first = mid + 1;
                }
                else if (arr[mid].sueldo == key)
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
