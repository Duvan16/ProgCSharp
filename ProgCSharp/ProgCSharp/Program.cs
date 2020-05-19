using System;
using System.Reflection;
using System.Security.Policy;

namespace ProgCSharp
{
    class Program
    {

        public class Cliente
        {
            public string nombre { get; set; }

            public int DNI { get; set; }

            public string   Email { get; set; }

            public int  telefono { get; set; }
        }

    public static object CombinarClientes(object tiendaA, object tiendaB)
    {
        if (tiendaA.GetType()!=tiendaB.GetType())
        {
            throw new Exception("Estos parámetros no son del mismo Tipo");
        }

        Object nuevaTienda = Activator.CreateInstance(tiendaA.GetType());

        foreach (PropertyInfo p in tiendaA.GetType().GetProperties())
        {
            Object tiendaAA = tiendaA.GetType().GetProperty(p.Name).GetValue(tiendaA);
            Object tiendaBB = tiendaB.GetType().GetProperty(p.Name).GetValue(tiendaB);
            Object tiendaAB = (tiendaAA == null || tiendaAA.ToString() == "" || tiendaAA.ToString() == "0" ? tiendaBB : tiendaAA);

            nuevaTienda.GetType().GetProperty(p.Name).SetValue(nuevaTienda, tiendaAB);
        }
        return nuevaTienda;
    }

        static void Main(string[] args)
        {
            Cliente tiendaAAA = new Cliente()
            {
                nombre = "Juan",
                DNI = 123456,
                telefono = 1212121
            };

            Cliente tiendaBBB = new Cliente()
            {
                nombre = "Juan Gomez Perez",
                DNI = 123456,
                Email = "juan@juan.com"
            };

            Cliente tiendaABAB = (Cliente)CombinarClientes(tiendaAAA, tiendaBBB);
            Console.WriteLine("El Cliente {0} tiene el DNI {1}, y también tiene el email {2} y el teléfono {3}", tiendaABAB.nombre, tiendaABAB.DNI, tiendaABAB.Email, tiendaABAB.telefono);
            Console.ReadKey();
        }
    }
}