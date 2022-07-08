/*
    Udemy - curso C# - Seção 03
    Estruturas - laço For

Exercício 04: Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. 
Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
*/

using System;
using System.Globalization;

namespace Ex04_EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double elemento01 = 0, elemento02 = 0, divisao = 0;
            string[] pares;

            Console.Write("Informe quantos pares serão lidos: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\nInforme o par de números:");
                pares = Console.ReadLine().Split(" - ");

                elemento01 = int.Parse(pares[0], CultureInfo.InvariantCulture);
                elemento02 = int.Parse(pares[1], CultureInfo.InvariantCulture);

                if (elemento01 == 0)
                {
                    divisao = 0.0;

                    Console.WriteLine(divisao);
                }

                else if (elemento02 == 0)
                {
                    Console.WriteLine("Divisão impossível.");
                }

                else
                {
                    divisao = elemento01 / elemento02;

                    Console.WriteLine(divisao.ToString("F2"));
                }
            }
        }
    }
}
