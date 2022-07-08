/*      
      Udemy - curso C#
        Seção 04

Exercício 02: Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
*/

using System;
using System.Globalization;

namespace Ex02_ClasseSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario pessoa01, pessoa02;
            double media_salarios;

            pessoa01 = new Salario();
            pessoa02 = new Salario();

            Console.Write("Informe seu nome: ");
            pessoa01.nome = Console.ReadLine();

            Console.Write("\n" + pessoa01.nome + ", informe seu salário: R$ ");
            pessoa01.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\n\n\nInforme seu nome: ");
            pessoa02.nome = Console.ReadLine();

            Console.Write("\n" + pessoa02.nome + ", informe seu salário: R$ ");
            pessoa02.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media_salarios = (pessoa01.salario + pessoa02.salario) / 2;

            Console.WriteLine("\n\n\nDados do primeiro funcionário:\nNome: " + pessoa01.nome + "\nSalário: R$ " + pessoa01.salario);
            Console.WriteLine("Dados do segundo funcionário:\nNome: " + pessoa02.nome + "\nSalário: R$ " + pessoa02.salario);
            Console.WriteLine("Salário médio = R$ " + media_salarios);
        }
    }
}
