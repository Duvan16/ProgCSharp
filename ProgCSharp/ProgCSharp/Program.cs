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
            string[] nombres = new string[2] { "Duvan Gonzalez", "http://facebook.com/duvangg" };

            for (IEnumerator e = nombres.GetEnumerator(); e.MoveNext(); Console.WriteLine(e.Current)) ;


            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.ReadKey();
        }
    }
}
