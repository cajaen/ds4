using System;

namespace Precioproducto
{
    class FormaPago
    {
        static void Main(string[] args)
        {
            decimal precio;
            do
            {
                Console.Write("Introduce el precio del producto: ");
            } while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0);

            Console.Write("Introduce la forma de pago (efectivo/tarjeta): ");
            string formaPago = Console.ReadLine().ToLower();

            if (formaPago == "tarjeta")
            {
                string numeroTarjeta;
                do
                {
                    Console.Write("Introduce el número de tarjeta (16 dígitos): ");
                    numeroTarjeta = Console.ReadLine();
                } while (numeroTarjeta.Length != 16 || !EsNumeroValido(numeroTarjeta));

                Console.WriteLine("Pago con tarjeta aceptado.");
            }
            else if (formaPago == "efectivo")
            {
                Console.WriteLine("Pago en efectivo aceptado.");
            }
            else
            {
                Console.WriteLine("Forma de pago no válida.");
            }
        }

        static bool EsNumeroValido(string numero)
        {
            foreach (char c in numero)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
