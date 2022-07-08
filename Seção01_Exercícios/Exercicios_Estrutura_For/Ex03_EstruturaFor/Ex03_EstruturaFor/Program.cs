/*
    Udemy - curso C# - Seção 03
    Estruturas - laço For

Exercício 03: Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, 
o segundo valor tem peso 3 e o terceiro valor tem peso 5.
*/

using System;
using System.Globalization;

namespace Ex03_EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a, b, c;
            string[] testes;

            Console.Write("Informe o número de casos de teste: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nTeste #" + i + " -> Informe os três valores reais:");
                testes = Console.ReadLine().Split(' ');
                a = double.Parse(testes[0], CultureInfo.InvariantCulture);
                b = double.Parse(testes[1], CultureInfo.InvariantCulture);
                c = double.Parse(testes[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine("\n" + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
