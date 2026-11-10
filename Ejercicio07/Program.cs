Console.WriteLine("Ejercicio 7");
Console.WriteLine();

Console.Write("Introduce el primer número: ");
int numero1 = int.Parse(Console.ReadLine()!);
Console.Write("Introduce el segundo número: ");
int numero2 = int.Parse(Console.ReadLine()!);

if (EsMultiplo(numero1, numero2))
{
    Console.WriteLine($"{numero1} es múltiplo de {numero2}");
}
else if (EsMultiplo(numero2, numero1))
{
    Console.WriteLine($"{numero2} es múltiplo de {numero1}");
}
else
{
    Console.WriteLine("Ninguno es múltiplo del otro");
}

static bool EsMultiplo(int primero, int segundo)
{
    if (segundo == 0)
    {
        return false;
    }
    return primero % segundo == 0;
}
