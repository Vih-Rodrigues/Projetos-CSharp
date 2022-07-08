using System;
using System.Globalization; // Namespace para uso do CultureInfo.InvariantCulture

namespace Programa03_SaidaVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diferença entre Write e WriteLine
            Console.WriteLine("Bom dia!"); // WriteLine pula 1 linha após a escrita
            Console.Write("Boa tarde!"); // Write apenas escreve
            Console.WriteLine("Boa noite!");
            Console.WriteLine("________________________");

            // Segunda parte da aula
            string nome = "Vitoria";
            int idade = 19;
            char genero = 'F';
            float salario = 1500.68135F;

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(genero);
            Console.WriteLine(salario.ToString("F2")); // ToString (pascal case) + ("F2) serve para delimitar a quantidade de casas após a virgula
            Console.WriteLine(salario.ToString("F2", CultureInfo.InvariantCulture)); // CultureInfo.InvariantCulture = informa que deseja-se ponto como separador de decimais
            Console.WriteLine("________________________");

            // Terceira parte da aula - PLACEHOLDERS
            Console.WriteLine("{0} tem {1} anos e tem salario igual a {2:F2} reais.", nome, idade, salario); //  F2 delimita as casas decimais após a virgula

            // Quarta parte da aula - INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem salario igual a {salario:F2} reais.");

            // Quinta parte da aula - CONCATENAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e tem salario igual a " + salario.ToString("F2") + " reais.");

            // CONCATENAÇÃO COM TROCA DE SEPARADOR DE DECIMAIS (VIRGULA POR PONTO) - somente com o método de concatenação é possível usar esse comando
            Console.WriteLine(nome + " tem " + idade + " anos e tem salario igual a " + salario.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}
