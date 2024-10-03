using System;

class Parcial1
{
    static void Main()
    {
        int N;
        do
        {
            Console.Write("Introducir tamaño de la matriz (debe ser número par): ");
            N = int.Parse(Console.ReadLine());
        } while (N % 2 != 0);

        int[,] matriz = new int[N, N];
        Random random = new Random();
        int sumaDiagonal = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == j && i != 0 && i != N - 1)
                {
                    matriz[i, j] = random.Next(101, 201);
                    sumaDiagonal += matriz[i, j];
                }
                else
                {
                    matriz[i, j] = 0;
                }
            }
        }

        Console.WriteLine("\nMatriz creada:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nSuma de los valores de la diagonal: {sumaDiagonal}");
    }
}



