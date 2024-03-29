﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirApiIP
{
    public class IPInformacoes
    {
        public string ip { get; set; }
        public string hostname { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string loc { get; set; }
        public string org { get; set; }
        public string postal { get; set; }
        public string timezone { get; set; }
        public string readme { get; set; }

        public override string ToString()
        {
            return $"IP: {ip} - Cidade: {city} - Região: {region} - País: {country} - Localização: {loc} - Código Postal: {postal} - Fuso Horário: {timezone}";
        }
    }
}
