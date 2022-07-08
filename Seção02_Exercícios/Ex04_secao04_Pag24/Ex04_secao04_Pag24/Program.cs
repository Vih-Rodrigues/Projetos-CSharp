/*
                                            Udemy - curso C#
                                    Seção 04 - Material de apoio
                                               Página 24

Exercício de fixação: Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
para ser responsável pelos cálculos.
*/

using System;
using System.Globalization;

namespace Ex04_secao04_Pag24
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, compra, valor_pagar;

            Console.Write("Qual é a cotação do dóla?\n-> ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?\n-> ");
            compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valor_pagar = ConversorDeMoeda.ConverteMoeda(compra, cotacao);

            Console.WriteLine("\nValor a ser pago em reais:\n\tR$ " + valor_pagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
