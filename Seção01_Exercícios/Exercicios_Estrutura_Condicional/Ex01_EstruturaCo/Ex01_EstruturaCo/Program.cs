/*
Udemy - Curso C#
Estruturas condicionais
Exercício 01: Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
 */

using System;

namespace Ex01_EstruturaCo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Informe um número inteiro:");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Nulo! Numero = zero.");
            }

            else if (numero < 0)
            {
                Console.WriteLine("Negativo!");
            }
                else
                {
                    Console.WriteLine("Positivo!");
                }
        }

    }
}