
int[] b = new int[] { 1, 2, 324, 64, 5, 57, 68, 8, 6, 57, 46, 32, 4543, 656, 35 };

int vetorIndexInicio = 0;
int vetorTamanho = b.Length;
int vetorIndexFinal = vetorTamanho - 1;
int i = 0;

Console.WriteLine("App: Vetor 01");

Console.WriteLine("O vetor B tem " + vetorTamanho + " elementos");
Console.WriteLine("O vetor B tem indexes válidos de " + vetorIndexInicio + " até " + vetorIndexFinal);
Console.WriteLine("Vamos ver os itens:");

for(i = 0; i < b.Length; i++)
{
    Console.WriteLine("b[" + i + "] = " + b[i]);
}

Console.WriteLine();

while (true)
{
    Console.WriteLine("Se quiser ler algum item específico, digite seu index:");
    int posicao = int.Parse(Console.ReadLine());
    Console.WriteLine("b[" + posicao + "] = " + b[posicao]);
}

Console.ReadKey();
