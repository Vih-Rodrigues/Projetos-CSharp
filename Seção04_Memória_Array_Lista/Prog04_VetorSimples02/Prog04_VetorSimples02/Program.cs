/*
    Udemy - Seção 06 - Página 16 do material de apoio

Fazer um programa para ler um número inteiro N e os dados (nome e
preço) de N Produtos. Armazene os N produtos em um vetor. Em
seguida, mostrar o preço médio dos produtos.
*/

using System;
using System.Globalization;

namespace Prog04_VetorSimples02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Produto[] vetor_produtos;
            string nome_main;
            double preco_main, soma_total = 0, media_precos;

            Console.Write("Digite a quantidade de produtos que serão informados: ");
            numero = int.Parse(Console.ReadLine());

            vetor_produtos = new Produto[numero]; // Instanciando o VETOR

            for (int i = 0; i < numero; i++)
            {
                Console.Write("\nInforme o nome do produto: ");
                nome_main = Console.ReadLine();

                Console.Write("Informe o preço do produto " + nome_main + ": R$ ");
                preco_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor_produtos[i] = new Produto { Nome = nome_main, Preco = preco_main };
            }

            for (int i = 0; i < numero; i++)
            {
                soma_total += vetor_produtos[i].Preco;
            }

            media_precos = soma_total / numero;

            Console.WriteLine("\nPreço médio: R$ " + media_precos.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
