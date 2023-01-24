
Console.WriteLine("Insira os nomes dessa forma (exemplo: 1) João; 2) Maria; ...):");
string nomesJuntos = Console.ReadLine();

string[] nomesSeparadosComNumero = nomesJuntos.Split(';');

for(int i = 0; i < nomesSeparadosComNumero.Length; i++)
{
    nomesSeparadosComNumero[i].Substring(0, 3);
    Console.WriteLine(nomesSeparadosComNumero[i]);
}

//1) Joao; 2) Maria; 3) Pedro; 4) Rafael