internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrio la aplicacion");
    }
}
// se quita sealed para permitir herencia
class ClaseBase
{
    public void test()
    {

    }

    public void moreTesting()
    {

    }
}
class ClaseHijo : ClaseBase
{

}