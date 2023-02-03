
Console.WriteLine("Informe o caminho do diretório a ser pesquisado:");
string caminho = Console.ReadLine();

Console.WriteLine("Informe o filtro de pesquisa:");
string filtro = Console.ReadLine();

var diretorio = new DirectoryInfo(caminho);

var arquivos = diretorio.GetFiles();

int totalArquivos = 0;

foreach (var arquivo in arquivos)
{
    var arquivoConteudo = System.IO.File.ReadAllText(arquivo.FullName);

    if (arquivoConteudo.Contains(filtro))
    {
        Console.WriteLine(arquivo.Name);
        totalArquivos++;
    }
}

if(totalArquivos > 0)
{
    Console.WriteLine($"O termo '{filtro}' foi encontrado em {totalArquivos} arquivo(s).");

} else
{
    Console.WriteLine("Não foi encontrado nenhum arquivo com o termo de pesquisa:" + filtro);
}