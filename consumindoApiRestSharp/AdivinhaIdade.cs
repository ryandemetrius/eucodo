using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumindoApiRestSharp
{
    public class AdivinhaIdade
    {
        public int Consultar(string nome)
        {
            var client = new RestClient("https://api.agify.io");
            var request = new RestRequest("?name=" + nome, Method.Get);
            return client.Execute<AgifyResposta>(request).Data.Age;
        }
    }
}
