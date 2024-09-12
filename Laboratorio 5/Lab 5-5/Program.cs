using System;
using System.Collections.Generic;

internal class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Carlos", Edad = 12 },
            new Estudiante { Nombre = "Maria", Edad = 10 },
            new Estudiante { Nombre = "Jose", Edad = 11 }
        };

        foreach (Estudiante estudiante in estudiantes)
        {
            Console.WriteLine("Nombre: " + estudiante.Nombre + ", Edad: " + estudiante.Edad);
        }
    }
}
