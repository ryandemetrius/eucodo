
/*
E: &&
OU: ||
NAO: !
*/

Console.WriteLine("Insira sua idade:");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual seu sexo? M para Masculino e F para Feminino");
string sexo = Console.ReadLine();

Console.WriteLine("Qual seu salário?");
double salario = double.Parse(Console.ReadLine());

/*
Se for maior que 20 anos e for mulher, salario aumenta 50%
Se for maior que 30 anos e for homem, salario aumenta em 10%
*/

if (sexo == "M" && idade > 30)
{
    salario = salario * 1.1;
}

if (sexo == "F" && idade > 20)
{
    salario = salario * 1.5;
}

Console.WriteLine("seu salário é igual a: " + salario);

Console.ReadKey();
