using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace ProgCSharp
{
    class Program
    {
        //[DataContract]
        class Cliente
        {
            //[DataMember]
            public string nombre { get; set; }

            //[DataMember]
            public string email { get; set; }
        }

        static void Main(string[] args)
        {
            // clase DataContactJsonSerializer
            /*
            Cliente objCliente = new Cliente()
            {
                nombre = "Juan",
                email = "duva@gma.com"
            };

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Cliente));

            MemoryStream objMs = new MemoryStream();
            js.WriteObject(objMs, objCliente);
            objMs.Position = 0;

            StreamReader sr = new StreamReader(objMs);

            string json = sr.ReadToEnd();
            objMs.Close();

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deserializar = new DataContractJsonSerializer(typeof(Cliente));

                Cliente objCliente2 = (Cliente)deserializar.ReadObject(ms);

                Console.WriteLine(objCliente2.nombre);
                Console.WriteLine(objCliente2.email);
                Console.ReadKey();
            }
            */

            // clase JavaScriptJsonSerializer

            /*Cliente objCliente = new Cliente()
            {
                nombre = "Juan",
                email = "duva@gma.com"
            };

            JavaScriptSerializer js = new JavaScriptSerializer();

            string json = js.Serialize(objCliente);

            JavaScriptSerializer js2 = new JavaScriptSerializer();

            Cliente deserializar = js2.Deserialize<Cliente>(json);

            Console.WriteLine("El nombre {0} tiene el email {1}", deserializar.nombre, deserializar.email);
            */

            // biblioteca de terceros Json.NET

            Cliente objCliente = new Cliente()
            {
                nombre = "Juan",
                email = "duva@gma.com"
            };

            string json = JsonConvert.SerializeObject(objCliente);

            Cliente objCliente2 = JsonConvert.DeserializeObject<Cliente>(json);

            Console.WriteLine("El nombre es {0} y tiene el email {1}", objCliente2.nombre, objCliente2.email);

            Console.ReadKey();
        }
    }
}