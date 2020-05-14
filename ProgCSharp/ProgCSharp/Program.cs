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
            //if (File.Exists("prueba.txt"))
            //{
            //    File.Delete("prueba.txt");
            //    if (File.Exists("prueba.txt") == false)
            //        Console.WriteLine("El archivo se ha eliminado...");
            //}
            //else
            //{
            //    Console.WriteLine("El archivo buscado ya no existe");
            //}

            //ELiminar Directorio
            //if (Directory.Exists("dirprueba"))
            //{
            //    Directory.Delete("dirprueba", true);
            //    if (Directory.Exists("dirprueba") == false)
            //        Console.WriteLine("Se ha eliminado el directorio...");
            //}
            //else
            //{
            //    Console.WriteLine("El Directorio buscado ya no existe");
            //}

            //Renombrar archivos
            //if (File.Exists("prueba.txt"))
            //{
            //    Console.WriteLine("Introduce el nuevo nombre del archivo");

            //    string nuevoArchivo = Console.ReadLine();

            //    if (nuevoArchivo != string.Empty)
            //    {
            //        File.Move("prueba.txt", nuevoArchivo);
            //        if (File.Exists(nuevoArchivo))
            //        {
            //            Console.WriteLine("El nombre del nuevo archivo es:" + nuevoArchivo);
            //        }
            //    }
            //}

            //Renombrar Directorio
            //if (Directory.Exists("dirprueba"))
            //{
            //    Console.WriteLine("Introduce el nuevo nombre del Directorio");

            //    string nuevoDirectorio = Console.ReadLine();

            //    if (nuevoDirectorio != string.Empty)
            //    {
            //        Directory.Move("dirprueba", nuevoDirectorio);

            //        if (Directory.Exists(nuevoDirectorio))
            //            Console.WriteLine("EL nuevo Directorio se llama: " + nuevoDirectorio);
            //    }
            //}
            //Console.ReadKey();

            // Crear un Directorio

            Console.WriteLine("Introduce el nombre del Directorio");

            string crearDirectorio = Console.ReadLine();

            if (crearDirectorio != string.Empty)
            {
                Directory.CreateDirectory(crearDirectorio);

                if (Directory.Exists(crearDirectorio))
                {
                    Console.WriteLine("EL nombre del Directorio que hemos creado es:" + crearDirectorio);

                }
            }
            Console.ReadKey();
        }
    }
}
