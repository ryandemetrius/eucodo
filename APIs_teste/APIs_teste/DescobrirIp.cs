using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace APIs_teste
{
    public class DescobrirIp
    {
        public string Descobrir() 
        {
            var client = new RestClient("https://api.ipify.org/?format=json");
            var request = new RestRequest("", Method.Get);
            return client.Execute<IpInformacoes>(request).Data.Ip;
        }
    }
}
