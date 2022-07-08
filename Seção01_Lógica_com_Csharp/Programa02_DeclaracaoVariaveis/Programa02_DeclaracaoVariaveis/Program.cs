using System;

namespace Programa02_DeclaracaoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            byte variavel01 = 126;
            int variavel02 = 1000;
            long variavel03 = 2000000000L;
            float variavel04 = 4.5f; // f a0 final do número para indicar que trata-se de um float
            double variavel05 = 5.4; // c# reconhece valores com ponto como doubles automaticamente
            char genero = 'F';
            char letra = '\u0041'; // \u indica que trata-se de código Unicode
            bool controle = false;
            
            // Variáveis especiais
            String nome = "Maria Green";
            Object objeto01 = "Alex Brown"; // Tipo object aceita qualquer tipo de dado
            Object objeto02 = 4.5f;

            // Valores minimos e maximos
            int variavel06 = int.MinValue;
            int variavel07 = int.MaxValue;
            decimal variavel08 = decimal.MinValue;
            decimal variavel09 = decimal.MaxValue;

            variavel01++; // ao acrescentar +1 a variavel atinge o limite de valor possivel

            Console.WriteLine(variavel01);
            Console.WriteLine(variavel02);
            Console.WriteLine(variavel03);
            Console.WriteLine(variavel04);
            Console.WriteLine(variavel05);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(controle);
            Console.WriteLine(nome);
            Console.WriteLine(objeto01);
            Console.WriteLine(objeto02);
            Console.WriteLine(variavel06);
            Console.WriteLine(variavel07);
            Console.WriteLine(variavel08);
            Console.WriteLine(variavel09);
        }
    }
}
