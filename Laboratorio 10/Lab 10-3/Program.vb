Imports System

Module Peso
    Sub Main()
        'Declaración de variables
        Dim M As Double
        Dim G As Double
        Dim P As Double

        'Asignación de valores
        G = 9.8
        Console.Write("Ingrese la masa del objeto: ")
        M = Console.ReadLine

        'Realizar los procesos
        P = M * G

        'Mostrar resultados
        Console.WriteLine("El peso del objeto es: {0}", P)
        Console.ReadKey()

    End Sub
End Module
