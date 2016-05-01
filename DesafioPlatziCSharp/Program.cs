using System;
using System.Collections.Generic;
using System.IO;
using DesafioPlatziCSharp;
// Usamos la característica de C# 6.0

namespace Desafio01PlatziCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Encabezado("Escribimos en un archivo binario la lista de Profesores");

            var listaProfesores = new List<Profesor>();

            Encabezado("Leemos la lista de Profesores del archivo de Texto");
            var lineasProfesores = File.ReadAllLines("./Files/Profesores.txt");

            int contador = 0;
            foreach (var linea in lineasProfesores)
            {
                listaProfesores.Add(new Profesor { Id = contador++, Nombres = linea });
                Console.WriteLine($"Profesor en posición {contador} es {linea}");
            }

            string rutaArchivoBinario = "./Files/Profesores.bin";

            Encabezado("Guardamos la misma lista en un archivo binario");
            using (var archivo = File.Open(rutaArchivoBinario, FileMode.OpenOrCreate))
            {
                using (var binario = new BinaryWriter(archivo))
                {
                    foreach (var profesor in listaProfesores)
                    {
                        binario.Write(profesor.Id);
                        binario.Write(profesor.Nombres);
                    }
                }
            }
            Console.ReadLine();
            Encabezado("Leeemos el archivo binario y lo imprimimos en pantalla");

            using (var archivoBinario = File.Open(rutaArchivoBinario, FileMode.Open))
            {
                using (var binario = new BinaryReader(archivoBinario))
                {
                    // Mientras se pueda leer.
                    while (binario.BaseStream.Position < binario.BaseStream.Length)
                    {
                        Console.WriteLine($"Id:{binario.ReadInt32()}, Nombre:{binario.ReadString()}");
                    }
                    Encabezado("Fin del archivo");
                }
            }

            Console.ReadLine();
        }

        private static void Encabezado(string mensaje)
        {
            Console.WriteLine("".PadRight(15, '-'));
            Console.WriteLine(mensaje);
            Console.WriteLine("".PadRight(15, '-'));
        }
    }
}
