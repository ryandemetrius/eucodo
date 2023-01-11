
Console.WriteLine("Olá, qual será o sabor da sua pizza?");
string saborPizza = Console.ReadLine();

Console.WriteLine("Quantas pizzas você deseja?");
int numPizza = int.Parse(Console.ReadLine());

Console.WriteLine("Deseja borda recheada?");
string borda = Console.ReadLine();

double precoPizza = (numPizza * 10);
int numBorda1 = 0; //criei essa var apenas para ela existir dentro do ultimo if

if (borda == "sim")
{
    Console.WriteLine("Em quantas pizzas?");
    int numBorda = int.Parse(Console.ReadLine());

    double precoBorda = (2 * numBorda);
    precoPizza = (precoPizza + numBorda * 2);

    numBorda1 = numBorda;
}

Console.Write("O seu pedido é: " + numPizza + " pizza(s) sabor " + saborPizza.ToLower() + ",") ;
    if (borda == "sim")
{
    Console.Write("com " + numBorda1 + " delas contendo borda recheada, ");
}

Console.WriteLine("o preço total é de " + precoPizza + " reais.");

Console.ReadKey();
