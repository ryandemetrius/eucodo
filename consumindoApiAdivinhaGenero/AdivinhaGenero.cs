using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumindoApiAdivinhaGenero
{
    public class AdivinhaGenero
    {
        public string Consultar(string nome) 
        {
            var client = new RestClient("https://api.genderize.io");
            var request = new RestRequest($"?name={nome}", Method.Get);
            var response = client.Execute(request);

            return client.Execute<GenderizeResposta>(request).Data.gender;
        }
        
    }
}
