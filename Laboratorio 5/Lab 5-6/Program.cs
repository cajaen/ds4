internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> paisesCapitales = new Dictionary<string, string>
        {
            {"México","Ciudad de México" },
            { "Argentina", "Buenos Aires"},
            {"República Dominicana","Santo Domingo" }
        };
        foreach (KeyValuePair<string, string> pasCap in paisesCapitales)
        {
            Console.WriteLine("La capital es " + pasCap.Value + "  " + "y el pais es: " + pasCap.Key);
        }
    }
}