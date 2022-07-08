/*
Udemy - Curso C#
Exemplo Aula 30 - Funções
Problema exemplo: Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.
*/

using System; // Declaração das bibliotecas

namespace Programa12_Função // Declaração do namespace desse programa
{
    class Program // Declaração da classe - dentro da classe se pode declarar as funções 
    {
        static void Main(string[] args) // Função padrão do C# - indica o entrepoint da aplicação, é nessa função que a execução se iniciará
        {
            int n1, n2, n3;
            double resultado;

            Console.WriteLine("Digite três números, um após o outro:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            resultado = Maior(n1, n2, n3);

            Console.WriteLine("\nMaior = " + resultado);
        }

        static int Maior(int a, int b, int c) // função tipo int pois retorna um inteiro
        {
            int maior;

            if (a > b && a > c)
            {
                maior = a;
            }

            else if (b > c)
            {
                maior = b;
            }

                else
                {
                    maior = c;
                }

            return maior;
        }
    }
}
