Console.WriteLine("Ejercicio 4");
Console.WriteLine();

Console.Write("Introduce un número: ");
int numero = int.Parse(Console.ReadLine()!);

if (EsPrimo(numero))
{
    Console.WriteLine($"{numero} es primo");
}
else
{
    Console.WriteLine($"{numero} no es primo");
}

static bool EsPrimo(int n)
{
    if (n < 2)
    {
        return false;
    }
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
