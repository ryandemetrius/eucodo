
int num = 0;
try
{
    Console.WriteLine("Digite um número:");
    num = int.Parse(Console.ReadLine());
    Console.WriteLine("O número é " + num);
}
catch (Exception erro)
{
    Console.WriteLine();
    Console.WriteLine("Ocorreu um erro inesperado: ");
    Console.WriteLine(erro);
    Console.WriteLine();
    Console.WriteLine();
}

