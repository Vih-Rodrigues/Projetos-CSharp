/*
    Udemy - curso C# - Seção 03
    Estruturas - laço For

Exercício 07: Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme 
exemplo.
*/

using System;

namespace Ex07_EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, primeiro = 0, segundo = 0, terceiro = 0;

            Console.WriteLine("Informe um número:");
            numero= int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 1; i <= numero; i++)
            {
                primeiro = i;
                segundo = i * i;
                terceiro = i * i * i;
                Console.WriteLine(primeiro + "\t" + segundo + "\t" + terceiro);
            }
        }
    }
}
