using System;
using System.Globalization;

namespace Programa08_Leitura02
{
    class Program
    {
        static void Main(string[] args)
        {
            // LEITURA DE DADOS NÃO STRINGS COM "PARSE"
            int n1 = int.Parse(Console.ReadLine());
            char caractere = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // TROCA A LEITURA DE VÍRGULA POR PONTO

            Console.WriteLine("Você digitou: " + n1);
            Console.WriteLine(caractere);
            Console.WriteLine(n2);
            Console.WriteLine(n3.ToString("F2", CultureInfo.InvariantCulture)); // FAZ A ESCRITA COM PONTO AOINVÉS DE VÍRGULA

            // SEGUNDA PARTE DA AULA - SPLIT

            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
