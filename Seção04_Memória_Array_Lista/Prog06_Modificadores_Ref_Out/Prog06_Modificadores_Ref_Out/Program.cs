/*
        Udemy - curso C#
            Seção 06

Página 25/26
Problema-questão exemplo: Suponha que se queira uma calculadora com uma operação para triplicar o valor de 
um número passado como parâmetro.
*/

using System;

namespace Prog06_Modificadores_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRIMEIRA PARTE -> EXEMPLO QUE NÃO FUNCIONA
            int a = 10;
            Calculadora.Triplo(a);
            Console.WriteLine(a);

            // SEGUNDA PARTE -> SOLUÇÃO COM REF QUE FUNCIONA
            int b = 10; // a função REF exige que a variável passada pelo parâmetro seja inicializada
            Calculadora.Triplo02(ref b);
            Console.WriteLine(b);

            // TERCEIRA PARTE DA AULA -> MODIFICADOR OUT
            int c = 20; 
            int triplo; // a função OUT NÃO exige que a veriável passada pelo parâmetro seja inicializada
            Calculadora.Triplo03(c, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
