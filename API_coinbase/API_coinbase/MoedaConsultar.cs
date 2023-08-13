using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace API_coinbase
{
    public class MoedaConsultar
    {
        public MoedaInfo Consultar()
        {
            var client = new RestClient("https://api.coinbase.com/v2/currencies");
            var request = new RestRequest("", Method.Get);
            return client.Execute<MoedaInfo>(request).Data;
        }
    }
}
