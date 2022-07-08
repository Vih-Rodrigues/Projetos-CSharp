/*
    Udemy - curso C# - Seção 03
    Estruturas - laço For

Exercício 05: Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1.
*/

using System;

namespace Ex05_EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemento, fatorial = 0;

            Console.Write("Informe um valor inteiro: ");
            elemento = int.Parse(Console.ReadLine());

            fatorial = elemento;

            if (elemento == 0)
            {
                fatorial = 1;
                Console.WriteLine("\nFatorial de " + elemento + " = " + fatorial);
            }

            for (int i = (elemento - 1); i >= 1; i--)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("\nFatorial de " + elemento + " = " + fatorial);
        }
    }
}
