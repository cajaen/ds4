using System;
using System.Collections.Generic;

class Aleatorios
{
    private Random generador;

    public Aleatorios()
    {
        generador = new Random();
    }

    public int GenerarNumeroEntreDos(int limiteInferior, int limiteSuperior)
    {
        return generador.Next(limiteInferior, limiteSuperior + 1);
    }

    public int[] GenerarArregloNoRepetido(int limiteInferior, int limiteSuperior, int cantidadElementos)
    {
        if (cantidadElementos > (limiteSuperior - limiteInferior + 1))
        {
            throw new ArgumentException("El rango es demasiado pequeño para generar suficientes números únicos.");
        }

        HashSet<int> numerosUnicos = new HashSet<int>();
        while (numerosUnicos.Count < cantidadElementos)
        {
            int numeroAleatorio = generador.Next(limiteInferior, limiteSuperior + 1);
            numerosUnicos.Add(numeroAleatorio);
        }

        return new List<int>(numerosUnicos).ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aleatorios aleatorio = new Aleatorios();

        int[] arregloNoRepetido = aleatorio.GenerarArregloNoRepetido(1, 20, 5);
        Console.WriteLine("Arreglo aleatorio de 5 números no repetidos entre 1 y 20:");
        foreach (int numero in arregloNoRepetido)
        {
            Console.WriteLine(numero);
        }

        Console.ReadLine();
    }
}

