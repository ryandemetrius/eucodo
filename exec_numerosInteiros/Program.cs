
Console.WriteLine("Insira o primeiro número:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo número:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o terceiro número:");
int num3 = int.Parse(Console.ReadLine());

if(num1 <= num2 && num1 <= num3)
{
    Console.WriteLine("O menor número é " + num1 + ".");

} else
{
    if(num2 <= num1 && num2 <= num3)
    {
        Console.WriteLine("O menor número é " + num2 + ".");

    } else
    {
        if (num3 <= num1 && num3 <= num2)
        {
            Console.WriteLine("O menor número é " + num3 + ".");
        }
    }
} 