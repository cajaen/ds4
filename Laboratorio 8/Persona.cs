using System;

public class Persona
{
	public string Nombre;
	public int Edad;
	public string NIF;
	void Cumpleaños()
	{
		Edad++;
	}

	public Persona(string nombre, int Edad, string nif)
	{
		Nombre = nombre;
		Edad = Edad;
		NIF = nif;
	}
}
class Trabajador : Persona
{
    public int Sueldo;

    Trabajador(int nombre, int edad, string nif, int sueldo)
        : base(nombre, edad, nif)
    {
        sueldo = sueldo;
    }
}