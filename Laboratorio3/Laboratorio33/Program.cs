using System;

namespace Laboratorio33
{
    public class CalculosMatematicos
    {
        public int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }

        public double CalculoArea(double radio)
        {
            return Math.PI * radio * radio;
        }

        public double CalculoPerimetro(double largo, double ancho)
        {
            return 2 * (largo + ancho);
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

            int resultadoOperacion = calculos.Calcular(a, b);
            Console.WriteLine("El resultado de (a+b)*(a-b) es: " + resultadoOperacion);

            Console.Write("Introduce el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = calculos.CalculoArea(radio);
            Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, areaCirculo);

            Console.Write("Introduce el largo del rectángulo: ");
            double largo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine());

            double perimetroRectangulo = calculos.CalculoPerimetro(largo, ancho);
            Console.WriteLine("El perímetro del rectángulo con largo {0} y ancho {1} es: {2}", largo, ancho, perimetroRectangulo);
        }
    }
}
