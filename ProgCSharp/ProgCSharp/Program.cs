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
        //delegate int delegado(int i);
        static void Main(string[] args)
        {
            //delegado miDelegado = y => y * y;
            //int j = miDelegado(5);
            //Console.WriteLine(j);
            //Console.ReadKey();

            /*int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 25, 27, 29, 50 };

            double valormedio = numeros.Where(num => num % 2 == 1).Average();
            Console.WriteLine(valormedio);
            Console.ReadKey();*/

            // Árboles de expresión

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in numeros.Where(x => {
                if (x <= 3)
                    return true;
                else if (x >= 7)
                    return true;
                return false;
            }))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}