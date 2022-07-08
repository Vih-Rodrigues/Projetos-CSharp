/* Estruturas Sequenciais
Exercício 05: Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
Calcule e mostre o valor a ser pago.
*/

using System;
using System.Globalization;

namespace Ex05_EstruturaSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo01, codigo02, quantidade01, quantidade02;
            double valor01, valor02, total;

            Console.WriteLine("Exercício 05 - TOTAL A PAGAR");
            Console.WriteLine("Informe o código da peça 01:");
            codigo01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de peças 01:");
            quantidade01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário de cada peça 01:");
            valor01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            Console.WriteLine("Informe o código da segunda peça:");
            codigo02 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de peças 02:");
            quantidade02 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário de cada peça 02:");
            valor02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (valor01 * quantidade01) + (valor02 * quantidade02);

            Console.WriteLine("");
            Console.WriteLine("Total a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");

            // SEGUNDA FORMA DE RESOLVER - COM VETOR

            string[] vetor;
            int codigoX, codigoY, quantidadeX, quantidadeY;
            double valorX, valorY, total02;

            Console.WriteLine("Exercício 05 - TOTAL A PAGAR");
            Console.WriteLine("Informe o código da primeira peça + quantidade de peças + valor unitário:");
            vetor = Console.ReadLine().Split(' ');

            codigoX = int.Parse(vetor[0]);
            quantidadeX = int.Parse(vetor[1]);
            valorX = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Informe o código da segunda peça + quantidade de peças + valor unitário:");
            vetor = Console.ReadLine().Split(' ');

            codigoY = int.Parse(vetor[0]);
            quantidadeY = int.Parse(vetor[1]);
            valorY = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            total02 = (valorX * quantidadeX) + (valorY * quantidadeY);

            Console.WriteLine("");
            Console.WriteLine("Total a pagar: R$ " + total02.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
        }
    }
}