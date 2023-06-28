using consumindoApiDadosDosEUA.QuickType;
using RestSharp;

var client = new RestClient("https://datausa.io/api");
var request = new RestRequest("/data?drilldowns=Nation&measures=Population", Method.Get);

var retorno = client.Execute<Temperatures>(request).Data;

foreach (var item in retorno.Data)
{
    Console.WriteLine($"País: {item.Nation} - População: {item.Population}");
}