
Console.WriteLine("Digite quando você foi contratado (dd/mm/aaaa):");
DateTime dataContratado = DateTime.Parse(Console.ReadLine());

DayOfWeek diaContratado = dataContratado.DayOfWeek;
DateTime folga = DateTime.Now;

if (diaContratado == DayOfWeek.Monday)
{
    folga = dataContratado.AddDays(77);
    string stringFolga = folga.ToShortDateString();
    Console.WriteLine($"Sua folga será em {stringFolga}.");

} else
{
    if (diaContratado == DayOfWeek.Wednesday)
    {
        folga = dataContratado.AddMonths(2);
        string stringFolga = folga.ToShortDateString();
        Console.WriteLine($"Sua folga será em {stringFolga}.");

    }
    else
    {
        Console.WriteLine("Sua folga será dia 01/06/2023.");
    }
}