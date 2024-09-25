class Program
{
    static void Main(string[] args)
    {
        // El arreglo for 
        for (int i = 1; i <= 100; i++)
        {
            // Verificarmossi es par o divisible entre 3
            if (i % 1 == 0 || i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}