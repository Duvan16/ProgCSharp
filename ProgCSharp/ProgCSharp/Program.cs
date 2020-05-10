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
            // Agregar Elementos Lista
            IList<int> entero = new List<int>();


            entero.Add(2);
            entero.Add(3);

            IList<string> cadena = new List<string>();

            cadena.Add("dos");
            cadena.Add("tres");

            IList<int> entero1 = new List<int>() { 2, 3 };
            IList<string> cadena1 = new List<string>() { "dos", "tres" };

            // método AddRange

            List<int> entero3 = new List<int>();
            entero3.AddRange(entero3);

            //Acceder a los elementoscolección List
            Console.WriteLine("EL valor en la posición 1 de es: {0}", entero[0]);
            foreach (int i in entero)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < entero.Count; i++)
            {
                Console.WriteLine(entero[i]);
            }
            Console.ReadKey();
            //Insertar elementos a la colección generica List
        }
    }
}
