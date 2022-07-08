/* Estrutura Sequencial
Exercício 01: Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa,
*/
using System;

namespace Ex01_EstruturaSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa 01 - SOMA");
            Console.WriteLine("Informe o primeiro valor:");
            int valor01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            int valor02 = int.Parse(Console.ReadLine());

            int resultado = valor01 + valor02;

            Console.WriteLine("Soma = " + resultado);
        }
    }
}
