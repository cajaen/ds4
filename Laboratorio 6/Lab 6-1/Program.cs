internal class Program
{
    private static void Main(string[] args)
    {
        int num = -1;
        Console.WriteLine("Digite el número deseado");
        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("No ha introducido un dígito válido");
        }

        Console.WriteLine(num);
    }
}
