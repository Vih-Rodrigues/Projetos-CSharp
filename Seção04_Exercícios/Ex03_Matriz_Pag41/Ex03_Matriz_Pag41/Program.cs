/*
    Udemy - curso C# - Seção 06

Página  41: Matrizes

Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros, podendo haver repetições. 
Em seguida, ler um número inteiro X que pertence à matriz. 
Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.
*/

/*
    Console.WriteLine(matriz.Length);           => Informa quantos elementos a matriz possui no total
    Console.WriteLine(matriz.Rank);             => Informa quanto é a primeira dimensão da matriz, isto é, sua quantidade de LINHAS
    Console.WriteLine(matriz.GetLength(0));     => Informa que a primeira dimensão da matriz (por isso 0), tem tamanho 2 (quantidade de LINHAS)
    Console.WriteLine(matriz.GetLength(1));     => Informa que a segunda dimensão da matriz possui tamanho 3, isto é, sua quantidade de COLUNAS
*/

using System;

namespace Ex03_Matriz_Pag41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para declarar uma matriz é necessário digitar o tipo de dados que serão aceitos + [,] pra informar que será um arranjo bidimensional
            int[,] matriz;
            int linhas, colunas, nPesquisa;

            Console.Write("Informe a quantidade de LINHAS que a matriz terá: ");
            linhas = int.Parse(Console.ReadLine());

            Console.Write("\nInforme a quantidade de COLUNAS que a matriz terá: ");
            colunas = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Iniciando a matriz...
            matriz = new int[linhas, colunas];

            Console.WriteLine("Tamanho da matriz = " + matriz.Length);

            int i, j;
            for (i = 0; i < linhas; i++) // LEITURA DAS LINHAS
            {
                string[] valor;
                Console.WriteLine("\nInforme os elementos que ocuparão a linha " + i + " :\n(Exemplo: '1 - 2 - 3')");
                valor = Console.ReadLine().Split(" - ");

                for (j = 0; j < colunas ; j++) // LEITURA DAS COLUNAS
                {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine("\n\nMatriz:\n");
            // Laço para MOSTRAR a matriz na tela
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.Write("\t" + matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.Write("\nInforme um número: ");
            nPesquisa = int.Parse(Console.ReadLine());

            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] == nPesquisa)
                    {
                        Console.WriteLine("\nNúmero " + nPesquisa + " encontrado na posição " + i + "," + j);

                        // Esquerda  
                        if (j > 0) 
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j-1]);
                        }

                        // Direita
                        if (j < colunas-1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }

                        // Acima
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }

                        // Abaixo
                        if (i < linhas-1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}