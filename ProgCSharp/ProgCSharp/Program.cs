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
    class Imprimir
    {
        public void ImprimirNumeros()
        {
            //lock (this)
            //{
            Monitor.Enter(this);
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Monitor.Exit(this);
            }
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Se va a realizar MultiThreading ********");

            Imprimir impr = new ProgCSharp.Imprimir();

            Thread[] hilo = new Thread[3];

            for (int i = 0; i < 3; i++)
            {
                hilo[i] = new Thread(new ThreadStart(impr.ImprimirNumeros));
                hilo[i].Name = "Hilo Hijo" + i;
            }

            foreach (Thread h in hilo)
            {
                h.Start();
            }
            Console.ReadKey();
        }
    }
}