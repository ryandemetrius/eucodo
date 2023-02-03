while (true)
{
    Console.WriteLine("Digite quando você saiu de férias:");
    DateTime saiuDeFerias = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Digite quando você voltou das férias:");
    DateTime voltouDeFerias = DateTime.Parse(Console.ReadLine());

    TimeSpan dias = voltouDeFerias.Subtract(saiuDeFerias);

    Console.WriteLine("Digite seu salário:");
    double salario = int.Parse(Console.ReadLine());

    double diasFormat = dias.TotalDays;

    salario = salario - (diasFormat * 15);

    if (salario < 0)
    {
        Console.WriteLine("Mês que vem, seu salário líquido será igual a 0 reais.");

    } else
    {
        Console.WriteLine($"Mês que vem, seu salário líquido será igual a {salario}.");
    }
}