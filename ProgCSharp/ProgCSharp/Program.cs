using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

delegate void numeros(int n);

namespace ProgCSharp
{
    public abstract class Hablar
    {
        public abstract void charlar();

        public virtual void adios()
        {
            Console.WriteLine("La Clase Hablar nos está diciendo ADIOS!!");
        }
    }

    public class Conversacion : Hablar
    {
        public override void charlar()
        {
            Console.WriteLine("Hola, estoy Charlando");
        }

        public override void adios()
        {
            Console.WriteLine("La Clase Conversación nos está diciendo ADIOS!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conversacion conversa = new Conversacion();
            conversa.charlar();
            conversa.adios();

            Console.ReadKey();
        }
    }
}
