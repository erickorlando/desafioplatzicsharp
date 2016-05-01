// Usamos la característica de C# 6.0
using static System.Console;

namespace Desafio03PlatziCSharp.ClienteWebApi
{


    class Program
    {
        static void Main()
        {
            Encabezado("Desafío N° 03 del Curso Básico de C# en Platzi\nConectar al Web API");

            //TODO: Terminar de conectar al Servicio.
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
