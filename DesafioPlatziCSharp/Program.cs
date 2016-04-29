using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Usamos la característica de C# 6.0
using static System.Console;
namespace DesafioPlatziCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Escribimos en un archivo binario la lista de Profesores");

            var listaProfesores = new List<Profesor>()
            {
                new Profesor { Id = 1, Nombres = "Juan Carlos", Apellidos = "Ruiz Pacheco"},
                new Profesor { Id = 2, Nombres = "Carlos", Apellidos = "Azaustre"},
                new Profesor { Id = 3, Nombres = "Mike", Apellidos = "Nieva"},
                new Profesor { Id = 4, Nombres = "Marcela", Apellidos = "Lango"}
            };

            var archivo = File.Open("Profesores.data", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (var binario = new BinaryWriter(archivo))
            {
                foreach (var profesor in listaProfesores)
                {
                    binario.Write(profesor.Id);
                    binario.Write(profesor.Nombres);
                    binario.Write(profesor.Apellidos);
                }
            }

            ReadLine();
        }
    }
}
