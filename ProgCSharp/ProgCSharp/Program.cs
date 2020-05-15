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
            // Comprimir archivo zip

            //ZipFile.CreateFromDirectory("E:/temp/prueba/archivos", "E:/temp/prueba/ejemplo01.zip", CompressionLevel.Optimal, false);


            // Descomprimir archivo zip

            ZipFile.ExtractToDirectory("E:/temp/prueba/ejemplo01.zip", "E:/temp/prueba/DireccionDestino");


        }
    }
}
;