using System;

namespace Laboratorio31
{
    public class CalculosMatematicos
    {
        public int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculosMatematicos calculos = new CalculosMatematicos();

            Console.Write("Introduce el primer numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultado = calculos.Calcular(a, b);

            Console.WriteLine("El resultado de (a+b)*(a-b) es: " + resultado);
        }
    }
}
