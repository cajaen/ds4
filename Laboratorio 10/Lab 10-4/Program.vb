Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Module Program
    Public Sub Main(args As String())

        Dim perrito As Perro = New Perro()
        perrito.nombre = "Firulais"
        perrito.raza = "Pastor Aleman"
        perrito.altura = "0.70cm"
        Console.WriteLine(perrito.comer("carne"))

        Dim perrito2 As Perro = New Perro()
        perrito2.nombre = "Boby"
        perrito2.altura = "o.60cm"

        Console.WriteLine(perrito2.comer("Pollo"))
        Dim perrito3 As Perro = New Perro("Rex", "Doberman", "0.80cm")

        Console.WriteLine(perrito3.comer("Pan"))

    End Sub
End Module
