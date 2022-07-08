/*
Udemy - Curso C#
Estruturas condicionais
Exercício 06: Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
*/

using System;
using System.Globalization;

namespace Ex06_EstruturaCo
{
    class Program
    {
        static void Main(string[] args)
        {
            double elemento;

            Console.WriteLine("Informe um valor numérico:");
            elemento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Comando CultureInfo.InvariantCulture utilizado para que o uauário possa informar números com '.'

            if (elemento < 0.0 || elemento > 100.0)
            {
                Console.WriteLine("Fora de intervalo.");
            }

                else if (elemento <= 25.0)
                {
                    Console.WriteLine("Intervalo [0 - 25]");
                }

                    else if (elemento <= 50.0)
                    {
                        Console.WriteLine("Intervalo [25 - 50]");
                    }

                        else if (elemento <= 75.0)
                        {
                            Console.WriteLine("Intervalo [50 - 75]");
                        }

                            else
                            {
                                Console.WriteLine("Intervalo [75 - 100]");
                            }
        }
    }
}
