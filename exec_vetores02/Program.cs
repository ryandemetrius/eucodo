
Console.WriteLine("Informe quantos numeros deseja gerar: ");
int qtdNumeros = int.Parse(Console.ReadLine());

int[] numeros = new int[qtdNumeros];

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Informe um número:");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Números capturados: ");

//filtrar numeros < 0

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] < 0)
    {
        Console.WriteLine(numeros[i]);
    }
}