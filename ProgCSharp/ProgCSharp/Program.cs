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
using System.Xml.Linq;
using System.Threading;
using System.Runtime.CompilerServices;

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> tarea1 = new Task<int>(() =>
            {
                int resultado = 1;

                for (int i = 1; i < 10; i++)
                {
                    resultado *= i;
                }

                return resultado;
            });
            tarea1.Start();

            Console.WriteLine("El resultado de la tarea es {0}", tarea1.Result);
            Console.ReadKey();
        }
    }
}