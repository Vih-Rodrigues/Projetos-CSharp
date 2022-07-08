/*
    Udemy - curso C# - Seção 06 - Página  37: Matrizes
*/

using System;

namespace Prog09_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para declarar uma matriz é necessário digitar o tipo de dados que serão aceitos + [,] pra informar que será um arranjo bidimensional
            double[,] matriz;

            // Iniciando a matriz...
            matriz = new double[2, 3]; // 2 linhas (0 e 1) e 3 colunas (0, 1 e 2)

            Console.WriteLine(matriz.Length); // Informa quantos elementos a matriz possio no total

            Console.WriteLine(matriz.Rank); // Informa quanto é a primeira dimensão da matriz, isto é, sua quantidade de LINHAS

            Console.WriteLine(matriz.GetLength(0)); // Informa que a primeira dimensão da matriz (por isso 0), tem tamanho 2 (quantidade de LINHAS)

            Console.WriteLine(matriz.GetLength(1)); // Informa que a segunda dimensão da matriz possui tamanho 3, isto é, sua quantidade de COLUNAS
        }
    }
}