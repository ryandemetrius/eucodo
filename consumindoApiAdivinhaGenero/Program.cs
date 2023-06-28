using System;
using Microsoft.VisualBasic.FileIO;
using RestSharp;

namespace consumindoApiAdivinhaGenero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome? Vou adivinhar seu gênero.");
            var nome = Console.ReadLine();

            AdivinhaGenero adivinha = new AdivinhaGenero();
            string gender = adivinha.Consultar(nome);

            if (gender == "male") 
            {
                Console.WriteLine("Você é do gênero masculino.");
            } else
            {
                Console.WriteLine("Você é do gênero feminino.");
            }
            

        }
    }
}