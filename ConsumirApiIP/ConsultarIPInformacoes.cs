using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ConsumirApiIP
{
    public class ConsultarIPInformacoes
    {
       public IPInformacoes Consultar(string ip)
       {
            var client = new RestClient("https://ipinfo.io/"+ ip +"/geo");
            var request = new RestRequest("", Method.Get);
            return client.Execute<IPInformacoes>(request).Data;

            return new IPInformacoes();
       }
    }
}
