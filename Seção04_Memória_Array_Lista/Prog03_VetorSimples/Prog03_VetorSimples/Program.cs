/*
    Udemy - curso C# - Seção 06 - Página 16 do material complementar

Fazer um programa para ler um número inteiro N e a altura de N pessoas.
Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
pessoas.
*/

using System;
using System.Globalization;

namespace Prog03_VetorSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double[] vetor;
            double contador = 0, media;

            Console.Write("Digite o número de pessoas que informarão suas respectivas alturas: ");
            numero = int.Parse(Console.ReadLine());

            vetor = new double[numero];

            Console.WriteLine("");

            for (int i = 0; i < numero; i++)
            {
                Console.Write((i + 1) + "º pessoa -> digite sua altura: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contador += vetor[i];
            }

            Console.WriteLine("\n\nVETOR:\n");
            for (int i = 0;i < numero; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            media = contador / numero;

            Console.WriteLine("\nAltura média = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
