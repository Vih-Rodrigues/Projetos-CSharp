/*
    Udemy - curso C# - Seção 06

Página  39: Matrizes

Exercício: Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros. 
Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.
*/

/*
    Console.WriteLine(matriz.Length);           => Informa quantos elementos a matriz possui no total
    Console.WriteLine(matriz.Rank);             => Informa quanto é a primeira dimensão da matriz, isto é, sua quantidade de LINHAS
    Console.WriteLine(matriz.GetLength(0));     => Informa que a primeira dimensão da matriz (por isso 0), tem tamanho 2 (quantidade de LINHAS)
    Console.WriteLine(matriz.GetLength(1));     => Informa que a segunda dimensão da matriz possui tamanho 3, isto é, sua quantidade de COLUNAS
*/

using System;

namespace Prog09_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para declarar uma matriz é necessário digitar o tipo de dados que serão aceitos + [,] pra informar que será um arranjo bidimensional
            int[,] matriz;
            int linhasEcolunas, contadorNegativos = 0;

            Console.Write("Informe a quantidade de linhas e colunas que a matriz terá: ");
            linhasEcolunas = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            // Iniciando a matriz...
            matriz = new int[linhasEcolunas, linhasEcolunas];

            int i, j;
            for (i = 0; i < linhasEcolunas; i++) // LEITURA DAS LINHAS
            {
                string[] valor;
                Console.WriteLine("\nInforme os elementos que ocuparão a linha " + i + " :\n(Exemplo: '1 - 2 - 3')");
                valor = Console.ReadLine().Split(" - ");

                for (j = 0; j < linhasEcolunas; j++) // LEITURA DAS COLUNAS
                {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine("\n\nMatriz:\n");
            // Laço para MOSTRAR a matriz na tela
            for (i = 0; i < linhasEcolunas; i++)
            {
                for (j = 0; j < linhasEcolunas; j++)
                {
                    Console.Write("\t" + matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nDiagonal Principal:");
            // Laço para MOSTRAR os elementos da diagonal princippal
            for (i = 0; i < linhasEcolunas; i++)
            {
                for (j = 0; j < linhasEcolunas; j++)
                {
                    if (j == i)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                }
            }

            // Laço para CONTAR negativos:
            for (i = 0; i < linhasEcolunas; i++)
            {
                for (j = 0; j < linhasEcolunas; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        contadorNegativos++;
                    }
                }
            }
            
            Console.WriteLine("\n\nNúmeros negativos = " + contadorNegativos);
            Console.WriteLine("São eles:");
            
            // Laço para MOSTRAR negativos:
            for (i = 0; i < linhasEcolunas; i++)
            {
                for (j = 0; j < linhasEcolunas; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
