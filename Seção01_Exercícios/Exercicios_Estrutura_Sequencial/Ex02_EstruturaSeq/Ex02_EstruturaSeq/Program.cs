/* Estruturas Sequenciais
Exercício 02: Faça um programa para ler o valor do raio de um círculo, e depois mostrar 
o valor da área deste círculo com quatro casas decimais conforme exemplos.
Fórmula da área: area = π . raio²
Considere o valor de π = 3.14159
*/

using System;
using System.Globalization;

namespace Ex02_EstruturaSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            
            Console.WriteLine("Exercício 02 - ÁREA");
            Console.WriteLine("Informe o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(raio, 2.0);

            Console.WriteLine("");
            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("");
        }
    }
}
