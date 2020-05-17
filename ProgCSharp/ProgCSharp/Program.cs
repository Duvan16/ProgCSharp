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
        static void Main(string[] args)
        {
            Thread hilo = Thread.CurrentThread;

            hilo.Name = "Hilo Principal de la Aplicación";

            Console.WriteLine("El Hilo Principal se llama {0}", hilo.Name);
            Console.ReadKey();
        }
    }
}