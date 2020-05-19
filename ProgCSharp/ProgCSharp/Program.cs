using System;
using System.IO;
using System.Xml.Serialization;

namespace ProgCSharp
{

    public class Persona
    {
        [XmlElement(Order = 2)]
        public string nombre;
        [XmlElement(Order = 1)]
       // [XmlAttribute("MayorEdad")]
        public int edad;
        [XmlIgnore]
        public string email;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "Angel";
            p.edad = 40;
            p.email = "juan@gao.com";

            XmlSerializer xs = new XmlSerializer(typeof(Persona));

            using (Stream s = File.Create(@"E:\temp\persona.xml"))
            {
                xs.Serialize(s, p);
            }

            Persona p2 = new Persona();

            using (Stream s = File.OpenRead(@"E:\temp\persona.xml"))
            {
                p2 = (Persona)xs.Deserialize(s);
            }

            Console.WriteLine("El nombre es {0} y tiene {1} años", p2.nombre, p2.edad);
            Console.ReadKey();
        }
    }
}