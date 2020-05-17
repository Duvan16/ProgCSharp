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

namespace ProgCSharp
{
    class Program
    {
        public static void LLamarHiloHijo()
        {
            //Console.WriteLine("El Hilo Hijo se está ejecutando");

            /*
            Console.WriteLine("Comienza la ejecución del Hilo Hijo");

            int parar = 5000;

            Console.WriteLine("El Hilo Hijo se parará duran {0} segundos", parar / 1000);

            Thread.Sleep(parar);

            Console.WriteLine("El Hilo Hijo continua su ejecución");
            */
            try
            {
                Console.WriteLine("Comienza la ejecución del Hilo Hijo");

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(i);
                }
                Console.WriteLine("El Hilo Hijo se ha completado");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Se ha producido la Excepción: ", e);
            }
            finally
            {
                Console.WriteLine("No se ha producido ningún error en la ejecución del Hilo Hijo");
            }
        }

        static void Main(string[] args)
        {
            ThreadStart refHijo = new ThreadStart(LLamarHiloHijo);
            Console.WriteLine("El Hilo Principal --> Esta creando el hilo hijo");

            Thread HiloHijo = new Thread(refHijo);
            HiloHijo.Start();

            Thread.Sleep(2000);

            Console.WriteLine("El Hilo Principal va a destruir el Hilo Hijo");

            HiloHijo.Abort();

            Console.ReadKey();
        }
    }
}