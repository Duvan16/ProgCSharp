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
        class Organismo
        {
            public void respirar()
            {
                Console.WriteLine("Respira");
            }

            public void mover()
            {
                Console.WriteLine("Se mueve");
            }

            public void crecer()
            {
                Console.WriteLine("Puede Crecer");
            }
        }

        public interface IAnimales
        {
            void multiCelulares();

            void sangreCaliente();
        }

        public interface IAnimal : IAnimales
        {
            void correr();

            void viviparo();
        }

        public interface IPajaro: IAnimales
        {
            void volar();
            void oviparo();
        }

        class Perro : Organismo,IAnimal
        {
            public void multiCelulares()
            {
                Console.WriteLine("Estos organismos son Multicelulares");
            }

            public  void sangreCaliente()
            {
                Console.WriteLine("Estos organismos son de Sangre Caliente");
            }

            public void correr()
            {
                Console.WriteLine("Este Organismo es capaz de correr");
            }

            public void viviparo()
            {
                Console.WriteLine("Este Organismo es vivíparo");
            }

        }

        class Aguila : Organismo,IPajaro
        {
            public void multiCelulares()
            {
                Console.WriteLine("Estos organismos son Multicelulares");
            }

            public void sangreCaliente()
            {
                Console.WriteLine("Estos organismos son de Sangre Caliente");
            }

            public  void volar()
            {
                Console.WriteLine("Este Organismo es capaz de volar");
            }

            public void oviparo()
            {
                Console.WriteLine("Este Organismo es Ovíparo");
            }
        }

        static void Main(string[] args)
        {
            Perro perros = new Perro();
            Console.WriteLine("Estas son las caracteristicas de los perros");
            perros.respirar();
            perros.mover();
            perros.crecer();
            perros.multiCelulares();
            perros.sangreCaliente();
            perros.correr();
            perros.viviparo();

            Aguila aguilas = new Aguila();
            Console.WriteLine("Estas son las caracteristicas de las Águilas");
            aguilas.respirar();
            aguilas.mover();
            aguilas.crecer();
            aguilas.multiCelulares();
            aguilas.sangreCaliente();
            aguilas.volar();
            aguilas.oviparo();

            Console.ReadKey();
        }
    }
}
