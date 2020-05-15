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
            // Extracción de archivos por instancias
            /*using (ZipArchive archivo = ZipFile.Open("E:/temp/prueba/Ejemplo01.zip",ZipArchiveMode.Read))
            {
                string destino = "E:/temp/prueba/extraccionZIP/";

                ZipArchiveEntry elemento1 = archivo.GetEntry("Archivo 1.txt");
                elemento1.ExtractToFile(destino + "Archivo 1.txt");

                ZipArchiveEntry elemento2 = archivo.GetEntry("Directorio 1/Archivo 1-1.txt");
                elemento2.ExtractToFile(destino + "Archivo 1-1.txt");
            }
            */

            // Crear archivo ZIP

            using (ZipArchive archivo = ZipFile.Open("E:/temp/prueba/ejemplo02.zip",ZipArchiveMode.Create))
            {
                string Origen = "E:/temp/prueba/ExtraccionZIP/";

                archivo.CreateEntryFromFile(Origen + "Archivo 1.txt", "Archivo 1.txt", CompressionLevel.Optimal);
                archivo.CreateEntryFromFile(Origen + "Archivo 1-1.txt", "Directorio 1/Archivo 1-1.txt", CompressionLevel.Optimal);
            }

        }
    }
}
;