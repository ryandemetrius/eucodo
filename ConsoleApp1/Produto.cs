using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Produto
    {

        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return "Produto " + Nome + " com " + Quantidade + " unidades e preço " + Preco;
        }
    }
}
