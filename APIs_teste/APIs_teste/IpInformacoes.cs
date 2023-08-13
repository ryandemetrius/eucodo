using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs_teste
{
    public class IpInformacoes
    {
        public string Ip { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Loc { get; set; }
        public string Org { get; set; }
        public string Postal { get; set; }
        public string Timezone { get; set; }
        public string Readme { get; set; }

        public override string ToString()
        {
            return $"IP: {Ip} - Cidade: {City} - Região: {Region} - País: {Country} - Localização: {Loc} - Fuso Horário: {Timezone}";
    }
    }
}
