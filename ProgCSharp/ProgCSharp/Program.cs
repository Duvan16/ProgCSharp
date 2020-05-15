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

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clase StreamReader
            /* try
             {
                 using (StreamReader leer = new StreamReader("c:/prueba.txt"))
                 {
                     string linea;

                     while ((linea=leer.ReadLine()) != null)
                     {
                         Console.WriteLine(linea);
                     }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("Se ha producido una excepción");
                 Console.WriteLine(e.Message);

             }
             Console.ReadKey();
              */

            // Clase StreamWriter

            string[] nombres = new string[] { "Duvan Gonzalez", "Pepita perez" };

            using (StreamWriter escribir = new StreamWriter("E:/prueba.txt"))
            {
                foreach (string nombre in nombres)
                {
                    escribir.WriteLine(nombre);
                }
            }

            using (StreamReader leer = new StreamReader("E:/prueba.txt"))
            {
                string linea;

                while ((linea = leer.ReadLine())!= null)
                {
                    Console.WriteLine(linea);
                }
            }
            Console.ReadKey();
        }
    }
}
;