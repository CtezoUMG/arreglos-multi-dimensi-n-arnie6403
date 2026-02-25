using System;

// 1. Lectura de datos: Configurada para los Test Cases de GitHub
string? linea1 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(linea1)) return;

if (!int.TryParse(linea1.Trim(), out int n) || n < 0)
{
    Console.Error.WriteLine("Entrada inválida: se esperaba un entero no negativo en la primera línea.");
    return;
}

string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
if (entrada.Length < n)
{
    Console.Error.WriteLine($"Entrada insuficiente: se esperaban {n} números, recibió {entrada.Length}.");
    return;
}

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    if (!int.TryParse(entrada[i], out numeros[i]))
    {
        Console.Error.WriteLine($"Formato inválido en el elemento {i}: '{entrada[i]}'");
        return;
    }
}

// --- INICIO DE LÓGICA DEL ALUMNO ---
// Instrucción: El alumno debe encontrar el valor máximo del arreglo 'numeros'
int maximo = numeros[0];
for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] > maximo) maximo = numeros[i];
}


// --- FIN DE LÓGICA DEL ALUMNO ---

// 2. Salida: Lo que el Autograding comparará
Console.WriteLine(maximo);
