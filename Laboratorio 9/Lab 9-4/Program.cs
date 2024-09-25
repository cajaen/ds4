using System;

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

    public int[] GenerarArregloAleatorio(int limiteInferior, int limiteSuperior, int cantidadElementos)
    {
        int[] resultado = new int[cantidadElementos];
        for (int i = 0; i < cantidadElementos; i++)
        {
            resultado[i] = generador.Next(limiteInferior, limiteSuperior + 1);
        }
        return resultado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aleatorios aleatorio = new Aleatorios();

        int numeroAleatorio = aleatorio.GenerarNumeroEntreDos(2, 10);
        Console.WriteLine("Número aleatorio entre 2 y 10: " + numeroAleatorio);

        int[] arregloAleatorio = aleatorio.GenerarArregloAleatorio(1, 20, 5);
        Console.WriteLine("Arreglo aleatorio de 5 números entre 1 y 20:");
        foreach (int numero in arregloAleatorio)
        {
            Console.WriteLine(numero);
        }

        Console.ReadLine();
    }
}

