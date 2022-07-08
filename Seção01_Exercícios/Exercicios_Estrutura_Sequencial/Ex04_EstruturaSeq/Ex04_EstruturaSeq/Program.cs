/* Estruturas Sequenciais
Exercício 04: Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
o valor que recebe por hora e calcula o salário desse funcionário. 
A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
*/

using System;
using System.Globalization;

namespace Ex04_EstruturaSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            Console.WriteLine("Exercício 04 - SALARIO");
            Console.WriteLine("Informe seu numero de funcionário:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhadas:");
            int horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor por hora trabalhada:");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorPorHora * horasTrabalhadas;

            Console.WriteLine("");
            Console.WriteLine("Funcionário: " + numero + " - Salario R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
        }
    }
}