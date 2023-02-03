
Console.WriteLine("Informe o caminho do arquivo:");
string caminhoArquivo = Console.ReadLine();

Console.WriteLine("Informe o texto a ser procurado dentro do arquivo:");
string textoProcurado = Console.ReadLine();

System.IO.StreamReader arquivo = new System.IO.StreamReader(caminhoArquivo);

int totalLinha = 0;

while (!arquivo.EndOfStream)
{
    string linha = arquivo.ReadLine();

    if (linha.ToLower().StartsWith(textoProcurado.ToLower()))
    {
        Console.WriteLine(linha);
        totalLinha++;
    }
}

Console.WriteLine("Total de linhas: " + totalLinha);

arquivo.Close();