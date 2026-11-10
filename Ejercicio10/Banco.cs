class Banco
{
    private Cliente cliente1;
    private Cliente cliente2;
    private Cliente cliente3;

    public Banco()
    {
        cliente1 = new Cliente("Ana");
        cliente2 = new Cliente("Luis");
        cliente3 = new Cliente("Marta");
    }

    public void Operar()
    {
        cliente1.Ingresar(100);
        cliente2.Ingresar(250.50);
        cliente3.Ingresar(75);
    }

    public void ObtenerEstado()
    {
        double total = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();
        Console.WriteLine($"Dinero total ingresado en el banco: {total}€");
        Console.WriteLine($"Cliente 1: {cliente1.GetCantidadTotal()}€");
        Console.WriteLine($"Cliente 2: {cliente2.GetCantidadTotal()}€");
        Console.WriteLine($"Cliente 3: {cliente3.GetCantidadTotal()}€");
    }

    static void Main()
    {
        Console.WriteLine("Ejercicio 10");
        Console.WriteLine();

        Banco banco = new Banco();
        banco.Operar();
        banco.ObtenerEstado();
    }
}
