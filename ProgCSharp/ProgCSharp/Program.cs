using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesDataContext db = new LinqToSql.ClientesDataContext();

            // Creación de un usuario
            /*
            Tabla nuevoCliente = new Tabla();

            nuevoCliente.Nombre = "Jose Antonio";
            nuevoCliente.Edad = 50;

            db.Tabla.InsertOnSubmit(nuevoCliente);
            */

            // Actualización de un usuario
            /*
            Tabla cliente = db.Tabla.FirstOrDefault(x => x.Nombre.Equals("Jose Antonio"));

            cliente.Nombre = "Luis Antonio";
            cliente.Edad = 45;
            */

            // Eliminación de un usuario
            /*
            Tabla cliente = db.Tabla.FirstOrDefault(x => x.Nombre.Equals("Paco"));
            db.Tabla.DeleteOnSubmit(cliente);
            */

            var cliente = from c in db.Tabla where c.Nombre == "Luis Antonio" select c;

            foreach (var c in cliente)
            {
                Console.WriteLine(c.Nombre);
            }
            db.SubmitChanges();
            Console.ReadKey();
        }
    }
}