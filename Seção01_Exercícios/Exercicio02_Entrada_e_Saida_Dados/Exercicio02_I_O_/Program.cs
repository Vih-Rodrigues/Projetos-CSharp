using System;
using System.Globalization;

namespace Exercicio02_I_O_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio: 
            Fazer um programa para executar a seguinte interação com o usuário, 
            lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
            Entre com seu nome completo:
            Alex Green
            Quantos quartos tem na sua casa?
            3
            Entre com o preço de um produto:
            500.50
            Entre seu último nome, idade e altura (mesma linha):
            Green 21 1.73
            */

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine(nome + ", possui " + quartos + " quartos em sua casa. Produto = R$" + preco.ToString("F2"));

            Console.WriteLine("");

            Console.WriteLine("Entre com seu último nome, sua idade e sua altura: ");
            string[] vetor = Console.ReadLine().Split(' ');
            string nome02 = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome02 + ", " + idade + " anos. Altura = " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
