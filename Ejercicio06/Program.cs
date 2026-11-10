Console.WriteLine("Ejercicio 6");
Console.WriteLine();

bool accesoConcedido = false;

for (int intento = 1; intento <= 3 && !accesoConcedido; intento++)
{
    Console.Write("Usuario: ");
    string usuario = Console.ReadLine()!;
    Console.Write("Contraseña: ");
    string contrasenia = Console.ReadLine()!;

    if (Login(usuario, contrasenia))
    {
        accesoConcedido = true;
        Console.WriteLine("Acceso concedido");
    }
    else
    {
        Console.WriteLine($"Usuario o contraseña incorrectos (intento {intento} de 3)");
    }
}

if (!accesoConcedido)
{
    Console.WriteLine("Has agotado los tres intentos");
}

static bool Login(string usuario, string contrasenia)
{
    return usuario == "usuario2DAM" && contrasenia == "pass2DAM";
}
