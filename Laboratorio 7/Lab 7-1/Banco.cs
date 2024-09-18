using System;

class Banco 
{
    private Cliente cliente1, cliente2, cliente3;
    private int monto;

    public Banco()
    {
        cliente1 = new Cliente("Carlos");
        cliente2 = new Cliente("Rolando");
        cliente3 = new Cliente("Anllelina");
    }

    public void Operar()
    {
        cliente1.Depositar (100); 
        cliente2.Depositar (150);
        cliente3.Depositar(200);
        cliente3.Extraer(150);
    }
    public void DepositosTotales()
    {
        int t = cliente1.RetornarMonto() +
                cliente2.RetornarMonto() +
                cliente3.RetornarMonto();
        Console.WriteLine("El total de dinero en el banco es: "+ t);
        cliente1.Imprimir();
        cliente2.Imprimir();
        cliente3.Imprimir();

    }
    
}
