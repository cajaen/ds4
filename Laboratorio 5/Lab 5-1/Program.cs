using System;

internal class Program
{
    private int[] sueldos;

    public void Cargar()
    {
        sueldos = new int[6];
        for (int f = 0; f < sueldos.Length; f++)
        {
            Console.Write("Ingrese sueldo del operario " + (f + 1) + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    public void Imprimir()
    {
        Console.Write("Los sueldos de los operarios: \n");
        for (int f = 0; f < sueldos.Length; f++)
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.ReadKey();
    }

    private static void Main(string[] args)
    {
        Program pv = new Program();
        pv.Cargar();
        pv.Imprimir();
    }
}
