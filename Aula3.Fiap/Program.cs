using Aula3.Fiap.Models;
using System;

namespace Aula3.Fiap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler o input do usuário

            Console.WriteLine("Digite a quantidade de cômodos:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem piscina?(true/false)");
            bool piscina = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite a àrea da casa:");
            var area = double.Parse(Console.ReadLine());

            //Utilizando atributos informados no construtor, com input do usuário
            var casa = new Casa(quantidade, piscina, area);

            // Construtor utilizando parâmetros pré definidos
            var casa2 = new Casa(6, true, 123);

            //Construtor sem parâmetros
            var casa3 = new Casa()
            {
                Comodos = 5,
                AreaTotal = 50
            };

            //Construtor com 1 parâmetro
            var casa4 = new Casa(70)
            {
                Piscina = true
            };

            Console.WriteLine($"{casa.Comodos}, {casa.Piscina}. {casa.AreaTotal}");
            Console.WriteLine($"{casa2.Comodos}, {casa2.Piscina}. {casa2.AreaTotal}");
            Console.WriteLine($"{casa3.Comodos}, {casa3.Piscina}. {casa3.AreaTotal}");
            Console.WriteLine($"{casa4.Comodos}, {casa4.Piscina}. {casa4.AreaTotal}");

        }
    }
}
