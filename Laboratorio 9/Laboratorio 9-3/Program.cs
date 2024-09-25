using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la primera medida: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la segunda medida: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la tercera medida: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Las medidas ingresadas forman un triángulo.");

            if (a == b && b == c)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Las medidas ingresadas no forman un triángulo.");
        }

        Console.ReadLine();
    }
}
