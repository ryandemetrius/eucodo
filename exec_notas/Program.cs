
Console.WriteLine("Insira sua nota do primeiro semestre:");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira sua nota do segundo semestre:");
double nota2 = double.Parse(Console.ReadLine());

double mediaAno = ((nota1 + nota2) / 2);
double pontosFaltou = (70 - mediaAno);

if (mediaAno >= 70)
{
    Console.WriteLine("Parabéns! Você foi aprovado com uma média anual de " + mediaAno + ".");

} else
{
    Console.WriteLine("Você foi reprovado! Faltaram " + pontosFaltou + " pontos para você ser aprovado.");
}

Console.ReadKey();