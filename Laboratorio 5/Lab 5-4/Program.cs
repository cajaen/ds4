internal class Program
{
    private static void Main(string[] args)
    {
        List<int> calificacion = new List<int> { 85, 90, 78, 92, 88 };
        int suma = 0;
        foreach (int calificacions in calificacion)
        {
            suma += calificacions;
        }

        double promedio = suma / (double) calificacion.Count;
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");

    }
}