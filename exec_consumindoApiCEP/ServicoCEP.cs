using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec_consumindoApiCEP
{
    public class ServicoCEP
    {
        public Endereco Consultar(string CEP)
        {
            string url = "https://viacep.com.br/ws/" + CEP + "/json/";

            string json = new System.Net.WebClient().DownloadString(url);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Endereco>(json);
        }
    }
}
