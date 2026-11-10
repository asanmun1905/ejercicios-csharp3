Console.WriteLine("Ejercicio 5");
Console.WriteLine();

Console.Write("Introduce la base: ");
double baseNumero = double.Parse(Console.ReadLine()!);
Console.Write("Introduce el exponente (entero, 0 o mayor): ");
int exponente = int.Parse(Console.ReadLine()!);

if (exponente < 0)
{
    Console.WriteLine("El exponente no puede ser negativo");
}
else
{
    Console.WriteLine($"Potencia (iterativa): {PotenciaIterativa(baseNumero, exponente)}");
    Console.WriteLine($"Potencia (recursiva): {PotenciaRecursiva(baseNumero, exponente)}");
}

static double PotenciaIterativa(double b, int exp)
{
    double resultado = 1;
    for (int i = 0; i < exp; i++)
    {
        resultado = resultado * b;
    }
    return resultado;
}

static double PotenciaRecursiva(double b, int exp)
{
    if (exp == 0)
    {
        return 1;
    }
    return b * PotenciaRecursiva(b, exp - 1);
}
