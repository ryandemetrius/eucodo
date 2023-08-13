
using APIs_teste;

string ip = new DescobrirIp().Descobrir();
Console.WriteLine("Seu ip é: " + ip);

IpInformacoes ipInformacoes = new DescobrirIpInformacoes().Consultar(ip);
Console.WriteLine("Informações do seu ip: ");
Console.WriteLine(ipInformacoes);
