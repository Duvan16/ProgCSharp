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
using System.Xml.Linq;

namespace ProgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string docXML = @"<Departamentos>
                                <Departamento>Administracion</Departamento>
                                <Departamento>Ventas</Departamento>
                                <Departamento>Atencion al cliente</Departamento>
                                <Departamento>Marketing</Departamento>
                               </Departamentos>
                            ";

            XDocument documento = new XDocument();
            documento = XDocument.Parse(docXML);

            // añadir elementos al documento XML

            documento.Element("Departamentos").Add(new XElement("Departamento", "Formacion"));
            documento.Element("Departamentos").AddFirst(new XElement("Departamento", "Finanzas"));


            //eliminar elementos del documento XML

            documento.Descendants().Where(e => e.Value == "Ventas").Remove();


            var resultado = documento.Element("Departamentos").Descendants();

            foreach (XElement elementos in resultado)
            {
                Console.WriteLine("El nombre del Departamento es: " + elementos.Value);
            }
            Console.ReadKey();
        }
    }
}