/*
    Udemy - curso C# - Seção 06
Material complementar - Página 21
-> Exercício fixação
*/

using System;

namespace Ex01_Vetor_Pag21
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeQuartos, numeroQuarto;
            QuartosAlugados[] quartosAlugadosMain;
            string nomeMain, emailMain;

            quartosAlugadosMain = new QuartosAlugados[10];

            Console.WriteLine("Bem-vindo(a) ao pensionato da Dona!\t=D");
            Console.Write("\nQuantos quartos serão alugados? ");
            quantidadeQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine("\nAluguel #" + (i+1) + " :");
                Console.Write("Nome: ");
                nomeMain = Console.ReadLine();

                Console.Write("Email: ");
                emailMain = Console.ReadLine();

                Console.Write("Quarto: ");
                numeroQuarto = int.Parse(Console.ReadLine());

                // Chamada do construtor com os dois argumentos
                quartosAlugadosMain[numeroQuarto] = new QuartosAlugados(nomeMain, emailMain);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quartosAlugadosMain[i] != null)
                {
                    Console.WriteLine(i + ": " + quartosAlugadosMain[i]);
                }
            }
        }
    }
}
