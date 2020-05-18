using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancelar = new CancellationTokenSource();
            CancellationToken token = cancelar.Token;

            Task tarea1 = new Task(() =>
            {
                for (int i = 1; i < 10000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Se ha solicitado la Cancelación de la Tarea");
                        return;
                    }

                    Console.WriteLine("El bucle está iterando por el valor {0}", i);
                }
            }, token);

            Console.WriteLine("Pulsa para comenzar la Tarea");
            Console.WriteLine("Pulsa para Cancelar la Tarea");
           
            Console.ReadKey();

            tarea1.Start();

            Console.ReadKey();

            cancelar.Cancel();

            Console.WriteLine("La Tarea se está cancelando...");

            Console.WriteLine("El método Principal ha finalizado");

            Console.ReadKey();
        }
    }
}