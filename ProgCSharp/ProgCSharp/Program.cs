using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCSharp
{
    class Program
    {
        public class ListaElementos<T>
        {
            private List<T> elementos;

            public ListaElementos()
            {
                elementos = new List<T>();
            }

            public void Agregar(T nuevoelemento)
            {
                elementos.Add(nuevoelemento);
            }

            public void Eliminar(T elementoseliminar)
            {
                elementos.Remove(elementoseliminar);
            }

            public void Listar()
            {
                foreach (var elemento in elementos)
                {
                    Console.WriteLine("El elemento es: {0}", elemento);
                }
            }

        }

        static void Main(string[] args)
        {
            ListaElementos<int> ListaEntera = new ListaElementos<int>();
            ListaEntera.Agregar(1);
            ListaEntera.Agregar(2);
            ListaEntera.Agregar(3);
            ListaEntera.Eliminar(2);

            ListaEntera.Listar();
            Console.ReadKey();

            ListaElementos<string> ListaCadena = new ListaElementos<string>();
            ListaCadena.Agregar("Duvan Gonzalez");
            ListaCadena.Agregar("Patricia");
            ListaCadena.Agregar("Paco");
            ListaCadena.Eliminar("Paco");

            ListaCadena.Listar();
            Console.ReadKey();
        }
    }
}
