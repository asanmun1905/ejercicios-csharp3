Console.WriteLine("Ejercicio 1");
Console.WriteLine();

Console.Write("¿De qué tamaño quieres el array?: ");
int tamanio = int.Parse(Console.ReadLine()!);
int[] numeros = new int[tamanio];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Introduce el valor {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma = suma + numeros[i];
}
double media = (double)suma / numeros.Length;

Console.WriteLine($"La suma es: {suma}");
Console.WriteLine($"La media es: {media}");
