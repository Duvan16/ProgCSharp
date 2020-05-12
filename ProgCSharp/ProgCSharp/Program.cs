using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer, crear, modificar
            //if (File.Exists("prueba.txt"))
            //{
            //    string contenido = File.ReadAllText("prueba.txt");
            //    Console.WriteLine("El contenido de este fichero es:");
            //    Console.WriteLine(contenido);
            //}

            //Console.WriteLine("Escribe el nuevo contenido:");
            //string contenido2 = Console.ReadLine();
            ////File.WriteAllText("prueba.txt", contenido2);
            //File.AppendAllText("prueba.txt", contenido2);

            //string contenido3 = File.ReadAllText("prueba.txt");
            //Console.WriteLine("El nuevo contenido es:");
            //Console.WriteLine(contenido3);
            //Console.ReadKey();

            // Eliminar Ficheros
            if (File.Exists("prueba.txt"))
            {
                File.Delete("prueba.txt");
                if (File.Exists("prueba.txt") == false)
                    Console.WriteLine("El archivo se ha eliminado...");
            }
            else
            {
                Console.WriteLine("El archivo buscado ya no existe");
            }
            Console.ReadKey();
        }
    }
}
