
using ArquivoTextoIP10seg;

string Caminhoarquivo = "C:\\Users\\ryand\\OneDrive\\Área de Trabalho";

string ip = new IPConsultar().Consultar().ip;


while (true)
{
    Console.WriteLine(ip);
    Thread.Sleep(1000);
}