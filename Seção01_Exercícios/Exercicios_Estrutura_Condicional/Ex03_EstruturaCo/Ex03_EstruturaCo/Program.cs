/*
Udemy - Curso C#
Estruturas condicionais
Exercício 03: Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
ordem crescente ou decrescente.
*/

using System;

namespace Ex03_EstruturaCo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int elemento01, elemento02;

            Console.WriteLine("Informe dois valores inteiros:");
            valores = Console.ReadLine().Split(' ');

            elemento01 = int.Parse(valores[0]);
            elemento02 = int.Parse(valores[1]);

            Console.WriteLine("");

            if (elemento01 % elemento02 == 0 || elemento02 % elemento01 == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS!");
            }

            else
            {
                Console.WriteLine("Não são multiplos!");
            }

            Console.WriteLine("");
        }
    }
}