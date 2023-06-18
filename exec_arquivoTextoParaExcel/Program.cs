
// If you use EPPlus in a noncommercial context
// according to the Polyform Noncommercial license:
using OfficeOpenXml;
using System.Drawing;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


Console.WriteLine("Insira o caminho do arquivo:");
string caminhoArquivo = @"c:\eucodo\textoParaPlanilha.txt";


Console.WriteLine("Qual será o nome da planilha?");
var nomePlanilha = "textoParaPlanilha";

string textoArquivo = System.IO.File.ReadAllText(caminhoArquivo);
string[] textoCortado = textoArquivo.Split(';');

string[] nomes = new string[textoCortado.Length / 3];
string[] emails = new string[textoCortado.Length / 3];
string[] telefones = new string[textoCortado.Length / 3];

for (int i = 0; i < textoCortado.Length; i += 3)
{
    nomes[i / 3] = textoCortado[i];
    emails[i / 3] = textoCortado[i + 1];
    telefones[i / 3] = textoCortado[i + 2];
}

var stream = new MemoryStream();
using (var package = new ExcelPackage(stream))
{
    var worksheet = package.Workbook.Worksheets.Add(nomePlanilha);

    worksheet.Cells["A1"].Value = "Nome";
    worksheet.Cells["B1"].Value = "Email";
    worksheet.Cells["C1"].Value = "Telefone";

    for (int i = 0; i < textoCortado.Length; i += 3)
    {
        int row = i / 3 + 2;

        worksheet.Cells["A" + row].Value = textoCortado[i];
        worksheet.Cells["B" + row].Value = textoCortado[i + 1];
        worksheet.Cells["C" + row].Value = textoCortado[i + 2];

    }

    package.Save();
    File.WriteAllBytes(@"c:\eucodo\textoParaPlanilha.xlsx", stream.ToArray());
}









