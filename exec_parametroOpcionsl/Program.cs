
/* exercicio resolvido sem parâmetro opcional (mais facil eu acho)
try
{
    Console.WriteLine("Informe sua idade:");
    int idade = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Informe um texto.");
}
*/

class meuPrograma
{
    static void Main()
    {
        string nome = ObterInformacao("Informe seu nome");
        string idade = ObterInformacao("Informe sua idade");
        string nomeCachorro = ObterInformacao();

        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("Idade: {0}", idade);
        Console.WriteLine("Nome do cachorro: {0}", nomeCachorro);

    }

    static string ObterInformacao(string texto = "Informe um texto")
    {
        Console.WriteLine(texto + ":");
        return Console.ReadLine();
    }
}   

