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
            p.hablar();
            p.setNombre("Duvan GOnzalez");
            Console.WriteLine("EL nombre: " + p.getNombre() + " ha sido modificado");
            Console.ReadKey();
        }
    }
}
