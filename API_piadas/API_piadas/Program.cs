using API_piadas;
using Newtonsoft;
using Newtonsoft.Json;

while (true)
{
    var piadainfo = new PiadaChamar().Chamar();

    Console.WriteLine(piadainfo.setup);

    Thread.Sleep(1000);

    Console.WriteLine(piadainfo.punchline);

    Console.WriteLine("===============================");
    Thread.Sleep(5000);
}