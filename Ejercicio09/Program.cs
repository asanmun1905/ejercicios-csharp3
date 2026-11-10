Console.WriteLine("Ejercicio 9");
Console.WriteLine();

int[] numeros = { 14, 8, 23, 5, 31, 17, 9 };

int posicion = PosicionMenor(numeros);

Console.WriteLine($"El número menor es {numeros[posicion]} y está en la posición {posicion}");

static int PosicionMenor(int[] array)
{
    int posicionMenor = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[posicionMenor])
        {
            posicionMenor = i;
        }
    }
    return posicionMenor;
}
