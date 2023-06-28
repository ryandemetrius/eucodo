using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exec_consumindoApiCEP
{
    public class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro{ get; set; }
        public string Localidade{ get; set; }
        public string Uf{ get; set; }
        public string Ibge{ get; set; }
        public string Ddd{ get; set; }
        public string Siafi{ get; set; }
        public string Gia{ get; set; }

        public override string ToString()
        {
            return "Endereço.Uf = " + Uf + Environment.NewLine +
                "Endereço.Localidade = " + Localidade + Environment.NewLine +
                "Endereço.Bairro = " + Bairro + Environment.NewLine +
                "Endereço.Logradouro = " + Logradouro + Environment.NewLine +
                "Endereço.Ddd = " + Ddd + Environment.NewLine +
                "Endereço.Cep = " + Cep + Environment.NewLine +
                "Endereço.Complemento = " + Complemento + Environment.NewLine +
                "Endereço.Gia = " + Gia + Environment.NewLine +
                "Endereço.Ibge = " + Ibge + Environment.NewLine;
        }
    }


    
}