
string texto = Console.ReadLine();

int posicao;
int ultimaPosicao = 0;

while (true)
{
    if (texto.IndexOf("{", ultimaPosicao) == -1)
    {
        Console.WriteLine("Programa encerrado, pois não encontrei mais {");
        break;
    }

    posicao = texto.IndexOf("{", ultimaPosicao);
    ultimaPosicao = posicao + 1;

    string variavel = texto.Substring(posicao, texto.IndexOf("{", posicao) - posicao + 1);

    Console.WriteLine(variavel);
}