
Console.WriteLine("Digite seu email:");
string email = Console.ReadLine();

if (email.StartsWith("ti."))
{
    Console.WriteLine("Não aceitamos que funcionários do departamento de tecnologia usem esse sistema");

} else if (email.EndsWith("agrotecnologia.com.br"))
{
    Console.WriteLine("Bem vindo ao sistema!");

} else
{
    Console.WriteLine("Sistema disponível somente para funcionários da Agro Tecnologia.");
}

Console.ReadKey();