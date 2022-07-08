/*
    Udemy - curso C# 
        Seção 06
Página 23/24
-> Modificador de Parâmetros Params

Problema-questão de exemplo: Suponha que se queira uma calculadora para calcular a soma de uma quantidade variável de valores. 
PARA NÃO USAR UMA solução ruim usando sobrecarga, É POSSÍVEL USAR O MODIFICADOR DE PARÂMETRO PARAMS
*/

using System;

namespace Prog05_ModificadorParams
{
    class Program
    {
        static void Main(string[ ] args)
        {
            int soma01;

            // CHAMADA DA FUNÇÃO/MÉTODO
            soma01 = Calculadora.Soma(new int[] { 2, 3 });

            Console.WriteLine(soma01);

            // SEGUNDA PARTE DA AULA: SEGUNDA FORMA DE RESOLVER A QUESTÃO PROBLEMA -> UTILIZANDO PARAMS

            int soma02;

            soma02 = Calculadora.SomaParams(4, 5);

            Console.WriteLine(soma02);
        }
    }
}