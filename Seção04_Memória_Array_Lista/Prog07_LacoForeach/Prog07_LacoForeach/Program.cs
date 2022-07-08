/*
    Udemy - curso C#
        Seção 06

Página 31
Laço Foreach -> Sintaxe opcional e simplificada para percorrer coleções
*/

using System;

namespace Prog07_LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Alex", "Bob" };

            // Para cada objeto string contido no vetor...
            foreach (string objeto in vetor)
            {
                Console.WriteLine(objeto); // Imprima esse objeto
            }
        }
    }
}
