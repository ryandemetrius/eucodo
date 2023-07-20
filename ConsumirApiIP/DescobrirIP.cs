using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ConsumirApiIP
{
    public class DescobrirIP
    {
        public string Descobrir()
        {
            var client = new RestClient("https://api.ipify.org/?format=json");
            var request = new RestRequest("", Method.Get);
            return client.Execute<IPInformacoes>(request).Data.ip;

        }
    }
}
