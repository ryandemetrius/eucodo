
while (true)
{
    string caminhoArquivo = "";

    try
    {
        Console.WriteLine("Digite o caminho do arquivo:");
        caminhoArquivo = Console.ReadLine();

        string textoLido = System.IO.File.ReadAllText(caminhoArquivo);

        Console.WriteLine("Digite o texto para ser procurado no arquivo:");
        string textoProcurar = Console.ReadLine();

        if (textoLido.Contains(textoProcurar))
        {
            Console.WriteLine("Texto encontrado no arquivo.");

        } else
        {
            Console.WriteLine("Texto não encontrado no arquivo");
        }
    }
    catch (Exception erro)
    {
        Console.WriteLine($"Falha ao ler o arquivo {caminhoArquivo} detalhes: {erro.Message}");
    }
}


