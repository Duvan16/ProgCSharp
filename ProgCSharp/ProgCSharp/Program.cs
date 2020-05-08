using System;
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
            //Console.WriteLine("Hello\tWorld \n Hola Mundo");
            //Console.ReadKey();

            const double pi = 3.14159;


            double radio;

            Console.WriteLine("Introduzca el valor del radio:");
            radio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = pi * radio * radio;

            Console.WriteLine("El radio es: {0}, y el Área del circulo es: {1}", radio, areaCirculo);

            Console.ReadKey();
        }
    }
}
