Console.WriteLine("Ejercicio 2");
Console.WriteLine();

Console.Write("Introduce una cadena de texto: ");
string cadena = Console.ReadLine()!;

Console.WriteLine($"Número de espacios en blanco: {ContarEspacios(cadena)}");

static int ContarEspacios(string texto)
{
    int contador = 0;
    for (int i = 0; i < texto.Length; i++)
    {
        if (texto[i] == ' ')
        {
            contador++;
        }
    }
    return contador;
}
