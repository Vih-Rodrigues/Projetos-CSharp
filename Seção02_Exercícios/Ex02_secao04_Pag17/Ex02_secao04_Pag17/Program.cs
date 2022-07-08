/*
    Udemy - curso C#

Seção 04 - Arquivo PDF
Página 17

Exercício 02: Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em 
seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o 
salário do funcionário com base em uma porcentagem dada (somente o salário bruto é 
afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe 
projetada abaixo.
*/

using System;
using System.Globalization;

namespace Ex02_secao04_Pag17
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario_main;
            double porcentagem_main;

            funcionario_main = new Funcionario();

            Console.Write("Nome: ");
            funcionario_main.Nome = Console.ReadLine();

            Console.Write("Salário bruto: R$ ");
            funcionario_main.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: R$ ");
            funcionario_main.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n" + funcionario_main);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            porcentagem_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario_main.AumentarSalario(porcentagem_main);

            Console.WriteLine("\nDados atualizados:\n" + funcionario_main);
        }
    }
}
