using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ArquivoTextoIP10seg
{
    public class IPConsultar
    {
        public IPInfo Consultar()
        {
            var client = new RestClient("https://api.ipify.org?format=json");
            var request = new RestRequest("", Method.Get);
            return client.Execute<IPInfo>(request).Data;

        }
    }
}
