using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ProgCSharp
{
    class Program
    {
        class Clientes
        {
            public string nombre { get; set; }
            public int edad { get; set; }
        }
        static void Main(string[] args)
        {
            // DECLARACIONES LAMBDA CON CLASES

            /*List<Clientes> cliente = new List<Clientes>() {
                new Clientes {nombre = "Duvan",edad=20},
                new Clientes {nombre="Patricia",edad=35}
            };

            var nombres = cliente.Select(x => x.nombre);

            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            // ordenar por edad
            var edad = cliente.OrderBy(x => x.edad);

            foreach (var e in edad)
            {
                Console.WriteLine("El cliente {0}, tiene {1} años", e.nombre, e.edad);
            }
            Console.ReadKey();*/

            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var lista = numeros.FindAll((i) =>
            {
                Console.WriteLine("El valor de i es: {0}", i);
                return true;
            });
            Console.ReadKey();
        }
    }
}