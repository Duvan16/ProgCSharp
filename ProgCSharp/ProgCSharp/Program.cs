using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using espacionombres1;
using espacionombres2;
using espacionombres2.espacionombres3;

namespace espacionombres1
{
    class clase1
    {
        public void funcion()
        {
            Console.WriteLine("Estoy dentro del Espacio de Nombres 1");
        }
    }
}

namespace espacionombres2
{
    class clase2
    {
        public  void funcion()
        {
            Console.WriteLine("Estoy dentro del Espacio de Nombre 2");
        }
    }

    namespace espacionombres3
    {
        class clase3
        {
            public void funcion()
            {
                Console.WriteLine("Estoy dentro del Espacio de Nombre 3");
            }
        }

    }


}

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //espacionombres1.clase en1 = new espacionombres1.clase();
            //espacionombres2.clase en2 = new espacionombres2.clase();

            clase1 en1 = new clase1();
            clase2 en2 = new clase2();
            clase3 en3 = new clase3();

            en1.funcion();
            en2.funcion();
            en3.funcion();

            Console.ReadKey();
        }
    }
}
