
string nome = "Ryan";
string idade = "16";
decimal salario = 5000.50m;

string msg1, msg2;

//string com interpolação ($)
msg1 = $"{nome} tem {idade} anos e ganha por mês {salario.ToString("C2")}";

//usando string format
msg2 = string.Format("{0} tem {1} anos e ganha por mês {2:N2}", nome, idade, salario);

Console.WriteLine("msg1:" + msg1);
Console.WriteLine("msg2:" + msg2);