using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;

namespace ProgCSharp
{
    class Program
    {
        [Serializable]
        class serializacion
        {
            public int id;
            public string nombre;
        }

        static void Main(string[] args)
        {
            serializacion objeto = new serializacion();

            objeto.id = 1;
            objeto.nombre = "Paco";

            IFormatter formatear = new BinaryFormatter();
            Stream stream = new FileStream(@"E:\temp\ejemplo.txt", FileMode.Create, FileAccess.Write);

            formatear.Serialize(stream, objeto);
            stream.Close();

            stream = new FileStream(@"E:\temp\ejemplo.txt", FileMode.Open, FileAccess.Read);

            serializacion objetonuevo = (serializacion)formatear.Deserialize(stream);

            Console.WriteLine(objetonuevo.id);
            Console.WriteLine(objetonuevo.nombre);

            Console.ReadKey();
        }
    }
}