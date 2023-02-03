
Console.WriteLine("Onde o arquivo será gerado?");
string caminhoArquivo = Console.ReadLine();

Console.WriteLine("Qual período deseja? Formato dd/mm/aaaa a dd/mm/aaaa.");
string periodo = Console.ReadLine();

DateTime dataInicial = DateTime.Parse(periodo.Split("a")[0]);
DateTime dataFinal = DateTime.Parse(periodo.Split("a")[1]);

System.IO.StreamWriter arquivo = new StreamWriter(caminhoArquivo, false);

for (DateTime data = dataInicial; data <= dataFinal; data = data.AddDays(1))
{
    arquivo.WriteLine(data.ToString("dd/MM/yyyy"));
}

arquivo.Close();