/*
    Udemy - curso C# - Seção 03
    Estruturas - laço For

Exercício 01: Leia um valor inteiro X (1 <= X <= 1000). 
Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
*/

using System;

namespace Ex01_EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;

            Console.Write("Informe um número inteiro: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("");
        }
    }
}
