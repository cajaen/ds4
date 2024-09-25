class ClaseBase
{
    public void test()
    {

    }
    public virtual void masTests()
    {

    }
}
// se corrijió error de compilacion quitando el modificador sealed
class ClaseHijo : ClaseBase
{
    public override void masTests()
    {

    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrio la aplicacion");
    }
}
