using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

delegate void numeros(int n);

namespace ProgCSharp
{
    class Program
    {
        //Definición de estructura 1
        /*struct Libros
        {
            public string titulo;
            public string autor;
            public string categoria;
            public int id_Libro;
        }*/

        struct Libros
        {
            public string titulo;
            public string autor;
            public string categoria;
            public int id_Libro;

            public void getValores(string t, string a, string c, int id)
            {
                titulo = t;
                autor = a;
                categoria = c;
                id_Libro = id;
            }

            public void mostrar()
            {
                Console.WriteLine("Título es:{0}", titulo);
                Console.WriteLine("Autor es: {0}", autor);
                Console.WriteLine("Categoría es: {0}", categoria);
                Console.WriteLine("ID es: {0}", id_Libro);
            }
        }

        static void Main(string[] args)
        {
            //Definición estructura 1
            /*Libros libro1;
            Libros libro2;

            libro1.titulo = "La computación en la Nube";
            libro1.autor = "Duvan Gonzalez";
            libro1.categoria = "Sistemas Operativos en la Nube";
            libro1.id_Libro = 123;

            libro2.titulo = "Aprende a Programar en C Sharp";
            libro2.autor = "Duvan Gonzalez";
            libro2.categoria = "Desarrollo Informático";
            libro2.id_Libro = 1234;

            Console.WriteLine("Estos son los datos del Libro 1");
            Console.WriteLine("El título es: {0}", libro1.titulo);
            Console.WriteLine("El autor es: {0}", libro1.autor);
            Console.WriteLine("La Categoría es: {0}", libro1.categoria);
            Console.WriteLine("El id del libros es:{0}", libro1.id_Libro);
            Console.WriteLine("");
            Console.WriteLine("Estos son los datos del Libro 2");
            Console.WriteLine("El título es: {0}", libro2.titulo);
            Console.WriteLine("El autor es: {0}", libro2.autor);
            Console.WriteLine("La Categoría es: {0}", libro2.categoria);
            Console.WriteLine("El id del libros es:{0}", libro2.id_Libro);

            Console.ReadKey();*/

            Libros libro1 = new Libros();
            Libros libro2 = new Libros();

            libro1.getValores("La computación en la Nube", "Duvan González", "Sistema Operativos en la Nube", 123);
            libro2.getValores("Aprende a programar en c Sharp", "Duvan González", "Desarrollo Informático", 124);

            libro1.mostrar();
            libro2.mostrar();

            Console.ReadKey();
        }
    }
}
