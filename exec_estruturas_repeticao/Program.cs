
//Contador de 1 a 9

/*

Console.WriteLine("Programa de Contagem:");

for(int i = 0; i<= 9; i++)
{
    Console.Write(i + ", ");
}
Console.WriteLine();

*/

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

int contador = 0;

Console.WriteLine("Digite o incremento: ");
int incremento = int.Parse(Console.ReadLine());

Console.WriteLine("Contando em ordem crescente: ");

for(contador = num1; contador <= num2; contador += incremento)
{
    Console.WriteLine(contador);
}

Console.WriteLine();
Console.WriteLine("Contando em ordem decrescente: ");

for(contador = num2; contador >= num1; contador -= incremento)
{
    Console.WriteLine(contador);
}

Console.ReadKey();