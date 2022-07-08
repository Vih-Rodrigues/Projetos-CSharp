/*
         Udemy - curso C#

        Seção 04 - Classes

Exercício 01: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha. 
*/

using System;

namespace Ex01_ClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa01, pessoa02;

            pessoa01 = new Pessoa();
            pessoa02 = new Pessoa();

            Console.Write("Informe seu nome: ");
            pessoa01.nome = Console.ReadLine();

            Console.Write("\n" + pessoa01.nome + ", informe sua idade: ");
            pessoa01.idade = int.Parse(Console.ReadLine());

            Console.Write("\n\nInforme seu nome: ");
            pessoa02.nome = Console.ReadLine();

            Console.Write("\n" + pessoa02.nome + ", informe sua idade: ");
            pessoa02.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da primeira pessoa:");
            Console.WriteLine("Nome: " + pessoa01.nome);
            Console.WriteLine("Idade: " + pessoa01.idade);

            Console.WriteLine("\nDados da segunda pessoa:");
            Console.WriteLine("Nome: " + pessoa02.nome);
            Console.WriteLine("Idade: " + pessoa02.idade);

            if (pessoa01.idade > pessoa02.idade)
            {
                Console.WriteLine("\nPessoa mais velha: " + pessoa01.nome);
            }

            else
            {
                Console.WriteLine("\nPessoa mais velha: " + pessoa02.nome);
            }
        }
    }
}
