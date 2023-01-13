
using System.Runtime.CompilerServices;
/*
 int[] numeros = new int[] { 1, 2, 3, 4, 5 };

// While
int i = 1;
while (i < numeros.Length)
{
    Console.WriteLine(numeros[i]);
    i ++;
}

// For
for(i = 1; i < numeros.Length; i ++)
{
    Console.WriteLine(numeros[i]);
}

// ForEach
foreach(var alo in numeros)
{
    Console.WriteLine(alo);
}
*/

Console.WriteLine("Digite o texto:");
string texto = Console.ReadLine();

foreach(char letra in texto)
{
    Console.WriteLine(letra);
}