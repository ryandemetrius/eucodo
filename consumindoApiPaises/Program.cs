
using RestSharp;

Console.WriteLine("Digite o nome do país:");
string país = Console.ReadLine();

var client = new RestClient("https://restcountries.com");
var request = new RestRequest($"/v3.1/name/{país}", Method.Get);
var response = client.Execute(request);

Console.WriteLine(response.Content);
