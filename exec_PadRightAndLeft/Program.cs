
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu email:");
string email = Console.ReadLine();

Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa):");
DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

string codigoHipotetico;

codigoHipotetico = dataNascimento.ToShortDateString().PadLeft(25, 'X');
codigoHipotetico += nome.PadRight(25, '#');
codigoHipotetico += email.PadLeft(50, '$');

Console.WriteLine("Código hipotético: ");
Console.WriteLine(codigoHipotetico);
Console.WriteLine("Tamanho: " + codigoHipotetico.Length);