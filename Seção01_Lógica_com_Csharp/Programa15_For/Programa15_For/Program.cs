/*
Udemy - curso C#
Seção 03 - Aula 34
Estrutura For
*/

using System;

namespace Program15_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros, valor = 0, soma = 0;

            Console.Write("Quantos números inteiros você vai digitar?\n-> ");
            numeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeros; i++)
            {
                Console.Write("\nValor #" + (i+1) + ": ");
                valor = int.Parse(Console.ReadLine());

                soma += valor;
            }

            Console.WriteLine("\nSoma = " + soma);
        }
    }
}
