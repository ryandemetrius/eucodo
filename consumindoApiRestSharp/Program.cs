/* using System;
using RestSharp;

namespace ConsumirAPI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();

            var client = new RestClient("https://api.agify.io");
            var request = new RestRequest($"?name={nome}", Method.Get);
            var response = client.Execute(request);

            Console.WriteLine(response.Content);

        }
    }
}
*/
using System;
using consumindoApiRestSharp;
using RestSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o seu nome?");
        string nome = Console.ReadLine();

        AdivinhaIdade adivinha = new AdivinhaIdade();
        int idade = adivinha.Consultar(nome);

        Console.WriteLine("Sua idade é " + idade.ToString());
    }
}