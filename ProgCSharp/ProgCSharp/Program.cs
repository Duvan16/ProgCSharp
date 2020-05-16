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
        static void Main(string[] args)
        {
            // DECLARACIONES MULTIPLES DE EXPRESIONES LAMBDA

            /*
            // expresión lambda tipada de manera implicita, creamos una instancia a la expresiónn
            Func<int, int> expresion1 = x => x + 1;

            //  usar la expresión lambda en el cuerpo de la declaración
            Func<int, int> expresion2 = x => { return x + 1; };

            //usamos  parámteros en la expresión lambda
            Func<int, int> expresion3 = (int x) => x + 1;

            //usando parámetros en la expresión para usar en el cuerpo de la declaración
            Func<int, int> expresion4 = (int x) => { return x + 1; };

            //usa lambda con varios parámetros
            Func<int, int, int> expresion5 = (x, y) => x * y;

            // usar lambda en un método delegado
            Func<int, int> expresion6 = delegate (int x) { return x + 1; };

            // usar lambda en un método delegado sin parámetros
            Func<int> expresion7 = delegate { return 1 + 1; };

            Console.WriteLine(expresion1.Invoke(1));
            Console.WriteLine(expresion2.Invoke(1));
            Console.WriteLine(expresion3.Invoke(1));
            Console.WriteLine(expresion4.Invoke(1));
            Console.WriteLine(expresion5.Invoke(1,1));
            Console.WriteLine(expresion6.Invoke(1));
            Console.WriteLine(expresion7.Invoke());

            Console.ReadKey();
            */
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 6, 7, 8, 9 };
            List<int> pares = numeros.FindAll(x => (x % 2) == 0);

            foreach (var p in pares)
            {
                Console.WriteLine("Los números pares son: {0}", p);
            }
            Console.ReadKey();

        }
    }
}