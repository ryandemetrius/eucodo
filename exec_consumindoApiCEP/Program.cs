
namespace exec_consumindoApiCEP
{

    class MeuPrograma
    {
        static void Main()
        {

            Console.WriteLine("Qual CEP deseja consultar?");
            string cep = Console.ReadLine();

            ServicoCEP servico = new ServicoCEP();
            Endereco endereco = servico.Consultar(cep);

            Console.WriteLine("Encontrei o endereço para o CEP informado: ");
            Console.WriteLine(endereco);

        }


    }










}