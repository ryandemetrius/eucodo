using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs_teste
{
    public class DescobrirIpInformacoes
    {
        public IpInformacoes Consultar(string ip)
        {
            var client = new RestClient("https://ipinfo.io/" + ip + "/geo");
            var request = new RestRequest("", Method.Get);
            return client.Execute<IpInformacoes>(request).Data;
        }
    }
}
