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
            Persona p = new Persona();
            p.nombre = "Duvan Gonzalez";
            p.ojos = 2;
            p.brazos = 2;
            p.piernas = 2;
            p.Colo_Ojos = "Castaño";
            p.Color_Pelo = "Moreno";
            Console.WriteLine("Mi nombre es: " + p.nombre + " y tengo: " + p.ojos + " ojos y además también tengo " + p.brazos + p.piernas + " piernas. Mi color de ojos es" + p.Colo_Ojos + "y mi color de pelo es: " + p.Color_Pelo);
            Console.ReadKey();
        }
    }
}
