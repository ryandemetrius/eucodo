using ConsoleApp1;

Produto p = new Produto();

Console.WriteLine("Digite o nome do produto:");
p.Nome = Console.ReadLine();

Console.WriteLine("Insira a quantidade do produto:");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço do produto:");
p.Preco = decimal.Parse(Console.ReadLine());

Console.WriteLine(p.ToString());


Console.ReadKey();