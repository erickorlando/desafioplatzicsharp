using System.IO;
using static System.Console;

namespace Desafio02PlatziCSharp
{
    class Program
    {
        static void Main()
        {
            Encabezado("Desafío 02: Lectura de Propiedades de un archivo BMP");
            using (var archivoBmp = File.Open("./Images/PlatziCSharp.bmp", FileMode.Open))
            {
                using (var imagenBmp = new BinaryReader(archivoBmp))
                {
                    imagenBmp.BaseStream.Seek(18, SeekOrigin.Begin);
                    WriteLine($"Ancho de la imagen: {imagenBmp.ReadInt32()}");

                    imagenBmp.BaseStream.Seek(22, SeekOrigin.Begin);
                    WriteLine($"Altura de la imagen: {imagenBmp.ReadInt32()}");

                    imagenBmp.BaseStream.Seek(28, SeekOrigin.Begin);
                    WriteLine($"Bits por Pixel: {imagenBmp.ReadInt32()}");
                }
            }

            ReadLine();
        }
        private static void Encabezado(string mensaje)
        {
            WriteLine("".PadRight(35, '-'));
            WriteLine(mensaje);
            WriteLine("".PadRight(35, '-'));
        }
    }
}
