/*
    Udemy - curso C# - Seção 03
    Estruturas - laço For

Exercício 06: Ler um número inteiro N e calcular todos os seus divisores.
*/

using System;

namespace Ex06_EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
