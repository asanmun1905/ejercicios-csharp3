class Cliente
{
    private string nombre;
    private double cantidadTotal;

    public Cliente(string nombre)
    {
        this.nombre = nombre;
        this.cantidadTotal = 0;
    }

    public void Ingresar(double cantidad)
    {
        cantidadTotal = cantidadTotal + cantidad;
    }

    public void Sacar(double cantidad)
    {
        if (cantidad > cantidadTotal)
        {
            Console.WriteLine($"{nombre} no tiene suficiente dinero para sacar {cantidad}€");
        }
        else
        {
            cantidadTotal = cantidadTotal - cantidad;
        }
    }

    public double GetCantidadTotal()
    {
        return cantidadTotal;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"{nombre} tiene {cantidadTotal}€ en su cuenta");
    }
}
