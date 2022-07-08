/*
                Udemy - curso C#

                    Seção 07

Material de apoio - página 06:

• Formatar: ToLower(), ToUpper(), Trim()
• Buscar: IndexOf, LastIndexOf
• Recortar: Substring(inicio), Substring(inicio, tamanho)
• Substituir: Replace(char, char), Replace(string, string)
• String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)

    Demais funções já vistas: 

• str.Split(' ')
• Conversão para numero: int x = int.Parse(str), int x =Convert.ToInt32(str)
• Conversão de número: str = x.ToString(), str = x.ToString("C"), str = x.ToString("C3"), str = x.ToString("F2") 
*/

using System;

namespace Prog04_MaisFuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            string converteMaiusculo = original.ToUpper();

            Console.WriteLine("Original: [" + original + "]");
            Console.WriteLine("\nToUpper: [" + converteMaiusculo + "]   => função para converter todas as letras para maiúsculo.");

            string converteMinusculo = original.ToLower();
            Console.WriteLine("\nToLower: [" + converteMinusculo + "]   => função para converter todas as letras para minúsculo.");

            string apagaEspaços = original.Trim();
            Console.WriteLine("\nTrim: [" + apagaEspaços + "]    => função para apagar todos os espaços antes do início e depois do fim dos caracteres.");

            int procuraPrimeiraOcorrencia = original.IndexOf("bc");
            Console.WriteLine("\nIndexOf ('bc'): posição " + procuraPrimeiraOcorrencia + "    => função para procurar a primeira ocorrência do parâmetro.");

            int procuraUltimaOcorrencia = original.LastIndexOf("bc");
            Console.WriteLine("\nLastIndexOf ('bc'): posição " + procuraUltimaOcorrencia + "    => função para procurar a última ocorrência do parâmetro.");

            // A função Substring tem duas sobrecargas (opções de parâmetros): por índice OU por índice + o tamanho que deseja-se cortar a string
            string cortaPedaco = original.Substring(3);
            Console.WriteLine("\nSubstring (índice 3): [" + cortaPedaco + "]    => 1º função para cortar um pedaço de uma string, no caso a 'original', da sua primeira posição (zero) até o índice informado.");

            // Nesse caso, o corte inicia na posição 3, e corta fora 5 caracteres
            string cortaPedacoDefinido = original.Substring(3, 5);
            Console.WriteLine("\nSubstring (índice 3, 5 caracteres): [" + cortaPedacoDefinido + "]    => 2º função para cortar um pedaço de uma string, no caso a 'original', da posição informada até a quantidade de caracteres informados.");

            // A função Replace tem algumas sobrecargas, as principais são: substituir um caracter E substituir uma string
            // Nesse caso, troca-se todo caractere 'a' por 'x'
            string substitui = original.Replace('a', 'x');
            Console.WriteLine("\nReplace (todo 'a', substituido por 'x'): [" + substitui + "]     => 1º função para substituir caracteres.");

            // Nesse caso, troca-se toda ocorrência "abc" por "xy"
            string substituiString = original.Replace("abc", "xy");
            Console.WriteLine("\nReplace (toda string 'abc', substituida por 'xy'): [" + substituiString + "]     => 2º função para substituir string.");

            // A função IsNullOrEmpty verifica se o conteúdo da string passada por parâmetro é nulo ou vazio, retornando verdadeiro (se for um dos dois) ou falso
            bool verificaNuloOuVazio = String.IsNullOrEmpty(original);
            Console.WriteLine("\nIsNullOrEmpty: " + verificaNuloOuVazio + "     => função para verificar se a string é nula ou vazia.");

            // A função IsNullOrWhiteSpace verifica se a variável é nula ou se é apenas vários espaços "em branco"
            bool verificaNuloOuEspacos = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("\nIsNullOrWhiteSpace: " + verificaNuloOuEspacos + "     => função para verificar se a string é nula ou se possui somente vários espaços em branco.");

            // A função Split corta uma string com base em um caractere e armazenas as string cortadas em um vetor de strings
            string[] CortaPorEspacos = original.Split(' ');
            Console.WriteLine("\n\nTamanho do vetor: " + CortaPorEspacos.Length);
            for (int i = 0; i < CortaPorEspacos.Length; i++)
            {
                Console.WriteLine("Split: [" + CortaPorEspacos[i] + "]     => função para cortar string em pedaços armazenados num vetor (corte por espaços).");
            }
        }
    }
}
