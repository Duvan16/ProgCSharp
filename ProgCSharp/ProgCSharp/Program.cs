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
        static void Tarea(object mensaje)
        {
            Console.WriteLine("Hola soy una Tarea: {0}", mensaje);
        }

        static void Main(string[] args)
        {
            // Crear instancia usando el delegado Action

            Task tarea1 = new Task(new Action<object>(Tarea), "Tarea 1");

            // crear instancia usando una función anónima

            Task tarea2 = new Task(delegate (object objeto)
            {
                Tarea(objeto);
            }, "Tarea 2");

            // crear instancia usando una función lambda

            Task tarea3 = new Task((objeto) => Tarea(objeto), "Tarea 3");

            tarea1.Start();
            tarea2.Start();
            tarea3.Start();

            Console.WriteLine("Se ha finalizado la ejecución de las tareas. Pulsa una tecla para salir");

            Console.ReadKey();
        }
    }
}