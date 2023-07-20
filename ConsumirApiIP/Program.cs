using ConsumirApiIP;

string ip = new DescobrirIP().Descobrir();
Console.WriteLine("Seu IP é: " + ip);

IPInformacoes ipInformacoes = new ConsultarIPInformacoes().Consultar(ip);
Console.WriteLine("Informações do seu IP: ");
Console.WriteLine(ipInformacoes);