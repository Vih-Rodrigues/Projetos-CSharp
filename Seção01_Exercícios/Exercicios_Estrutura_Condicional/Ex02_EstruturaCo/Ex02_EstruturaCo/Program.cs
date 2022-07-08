/*
Udemy - Curso C#
Estruturas condicionais
Exercício 02: Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
*/

using System;

namespace Ex02_EstruturaCo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Informe um número inteiro:");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 != 0)
            {
                Console.WriteLine("IMPAR!");
            }

            else
            {
                Console.WriteLine("PAR!");
            }
        }
    }
}
