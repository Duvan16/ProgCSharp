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
        class Colegio
        {
            public int id { get; set; }
            public string nombre { get; set; }
        }
        static void Main(string[] args)
        {
            //Ejemplo de un array
            /*
            string[] nombres = { "Duvan", "Patricia", "Alex","David" };

            var lista = from n in nombres select n;

            foreach (var l in lista)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();*/

            // Ejemplo con una clase

            List<Colegio> colegios = new List<Colegio>();

            colegios.Add(new Colegio { id = 1, nombre = "Colegio 1" });
            colegios.Add(new Colegio { id = 2, nombre = "Colegio 2" });
            colegios.Add(new Colegio { id = 3, nombre = "Colegio 3" });

            var colegioLista = from c in colegios select c;

            foreach (var c in colegioLista)
            {
                Console.WriteLine("El Colegio con id {0} se llama {1}", c.id, c.nombre);
            }
            Console.ReadKey();
        }
    }
}