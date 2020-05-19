using System;
using System.Reflection;

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly MiEnsamblaje = Assembly.LoadFile(@"E:\NetCore\ProgCSharp\ProgCSharp\Calculadora\bin\Debug\Calculadora.dll");

            Type MiTipo = MiEnsamblaje.GetType("Calculadora.Class1");

            object instancia = Activator.CreateInstance(MiTipo);

            Type ObjTipo = instancia.GetType();

            foreach (MemberInfo objeto in ObjTipo.GetMembers())
            {
                Console.WriteLine(objeto.Name);
            }
            Console.ReadKey();
        }
    }
}