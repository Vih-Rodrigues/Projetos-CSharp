/*
    Udemy - curso C#

Seção 04 - Arquivo PDF
Página 18

Exercício 03: Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o
aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este
problema.
*/

using System;
using System.Globalization;

namespace Ex03_secao04_Pag18
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno_main;

            aluno_main = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno_main.Nome = Console.ReadLine();

            Console.Write("Digite a nota do primeiro trimestre: ");
            aluno_main.Nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a nota do segundo trimestre: ");
            aluno_main.Nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a nota do terceiro trimestre: ");
            aluno_main.Nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n" + aluno_main);

            if (aluno_main.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }

            else
            {
                Console.WriteLine("REPROVADO\nFALTARAM " + aluno_main.Faltou().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
