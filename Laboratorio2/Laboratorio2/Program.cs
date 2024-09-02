using Microsoft.VisualBasic;
using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            // Ejemplo utilizando las variables de instancia de Clase.
            client.FirstName = "Gabriel";
            client.LastName = "Rodriguez";
            client.Age = 24;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

        }
    }

    public class Client
    {
        // Declarando variables de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            // Utilizando variables de instancia dentro de metodos de la clase.
            return FirstName + " " + LastName;
        }
    }

}


using System;

namespace Laboratorio21
{
    public class Program
    {
        public static void Main()
        {
            // Asignando valor a variable estatica.
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);

            // Declarando y asignando variables de instancia
            int valor1 = 28;
            int valor2 = valor1;
            valor2 = 30;

            // Imprimiendo en consola variables
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            // Creando nueva instancia
            MyClass object1 = new MyClass();
            object1.Nombre = "Jeancarlo";
            object1.Edad = 31;

            // Asignando una variable a otra
            MyClass object2 = object1;

            // Este cambio en la propiedad afecta tanto a object1 como object2.
            object2.Nombre = "Mario";

            // Al imprimir en consola vemos que ambas referencias imprimen el mismo valor Jose.
            Console.WriteLine(object1.Nombre);
            Console.WriteLine(object2.Nombre);

            char caracter = 'A'; // Variable almacenando el caracter 'A'
            string cadena = "Cadena de caracteres"; // Variable almacenando una cadena de caracteres

            Console.WriteLine(caracter);
            Console.WriteLine(cadena);
        }
    }

    public class MyClass
    {
        // Declarando variable estatica
        public static int Valor;

        // Declarando variables de instancia
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
