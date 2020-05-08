using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // método string
            string nombre = "Alexander Gonzalez";
            string apellidos = nombre.Substring(10, 8);

            Console.WriteLine(apellidos);


            // método indexOf
            string nombre1 = "Alexandre Gonzalez - Programando en c#";
            int posicion1 = nombre1.IndexOf("Programando");
            Console.WriteLine(posicion1);

            int posicion2 = nombre1.IndexOf("Gonzalez", 5);
            Console.WriteLine(posicion2);


            // funciones startwith y Endwith
            string archivo = "comc123.dll";

            if (archivo.StartsWith("com"))
            {
                Console.WriteLine("El archivo comienza con el texto COM");
            }

            if (archivo.EndsWith(".dll"))
            {
                Console.WriteLine("El archivo es una libreria");
            }


            //Extensiones PadLeft y PadRight

            string nombre4 = "Gonzalez";
            string codigo = "123";

            nombre4 = nombre4.PadRight(10, 'X');
            codigo = codigo.PadLeft(6, '0');

            Console.WriteLine(nombre4 + codigo);


            // funciones Split y Join

            string linea = "Prueba, 10 , 20, 02/05/2020";
            string[] campos = linea.Split(new char[] { ',' });
            Console.WriteLine(campos[0]);
            Console.WriteLine(campos[1]);
            Console.WriteLine(campos[2]);
            Console.WriteLine(campos[3]);


            string lineanueva = string.Join(";", campos);
            Console.WriteLine(lineanueva);


            // función format
            string formato = string.Format("Aquí voy a poner el {0}. Ahora son las {1}. Este es un valor numerico {2}", "parámetro que yo quiera poner", DateTime.Now, 15);
            Console.WriteLine(formato);
            Console.ReadKey();
        }
    }
}
