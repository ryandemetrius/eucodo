using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace API_piadas
{
    public class PiadaChamar
    {
        public PiadaInfo Chamar()
        {
            var client = new RestSharp.RestClient("https://official-joke-api.appspot.com/random_joke"); //erro quando coloco https://official-joke-api.appspot.com/jokes/programming/random
            var request = new RestSharp.RestRequest("", Method.Get);
            return client.Execute<PiadaInfo>(request).Data;
        }
    }
}
