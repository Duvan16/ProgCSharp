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
            ArrayList objetos = new ArrayList();

            objetos.Add(50);//boxing

            int x = (int)objetos[0]; //unboxing

            foreach (int i in objetos)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
