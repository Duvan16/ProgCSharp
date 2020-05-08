using System;
using System.Collections;
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
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine("Los Elementos de la lista son:");

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }

            Console.WriteLine("Ahora el conteinido de nuestra cola son:" + q.Count);


            //Implementación stack

            Stack s = new Stack();

            s.Push(1);
            s.Push(2);
            s.Push(3);

            Console.WriteLine("Los Elementos que tenemos en la pila son:");

            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine("Los Elementos que hay ahora en la pila son:" + s.Count);
            Console.ReadKey();
        }
    }
}
