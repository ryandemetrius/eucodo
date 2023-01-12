
using exec_funcionario;
funcionario f = new funcionario();

Console.WriteLine("Digite seu nome:");
f.nome = Console.ReadLine();

Console.WriteLine("Informe seu salário:");
f.salario = int.Parse(Console.ReadLine());

Console.WriteLine(f.ToString());
