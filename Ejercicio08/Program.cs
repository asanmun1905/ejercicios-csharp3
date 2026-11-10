Console.WriteLine("Ejercicio 8");
Console.WriteLine();

Console.Write("Introduce un número: ");
int numero = int.Parse(Console.ReadLine()!);

Console.WriteLine($"La suma de los dígitos de {numero} es {SumaDigitos(numero)}");

static int SumaDigitos(int n)
{
    n = Math.Abs(n);
    int suma = 0;
    while (n > 0)
    {
        suma = suma + n % 10;
        n = n / 10;
    }
    return suma;
}
