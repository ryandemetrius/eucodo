
Console.WriteLine("URL do site:");
string siteURL = Console.ReadLine();

string html = new System.Net.WebClient().DownloadString(siteURL);

int ultimaPosicao = 0;
int posicao = 0;

while (true)
{
    posicao = html.IndexOf("href", ultimaPosicao);

    if (posicao == -1)
        break;

    int posicaoFinal = html.IndexOf("\"", posicao + 6);
    string link = html.Substring(posicao + 6, posicaoFinal - posicao - 6);

    if (link.StartsWith("http") && link.EndsWith("exe"))
    { 
        string nomeArquivo = link.Substring(link.LastIndexOf("/") + 1);
        if (!System.IO.File.Exists(nomeArquivo))
        {
            Console.WriteLine("Baixando " + nomeArquivo);
            new System.Net.WebClient().DownloadFile(link, nomeArquivo);
        }
    }

    ultimaPosicao = posicaoFinal;
}