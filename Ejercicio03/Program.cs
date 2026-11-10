Console.WriteLine("Ejercicio 3");
Console.WriteLine();

Console.Write("Introduce un número: ");
int numero = int.Parse(Console.ReadLine()!);

Console.WriteLine($"El factorial de {numero} es {Factorial(numero)}");

static long Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    return n * Factorial(n - 1);
}
