using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec_funcionario
{
    public class funcionario
    {
        public string nome { get; set; }
        public int salario { get; set; }

        public override string ToString()
        {
            return "Funcionario " + nome + " com férias igual a " + salario* 1.3 + " reais.";
        }
    }
}
