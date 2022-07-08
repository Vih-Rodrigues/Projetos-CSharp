using System;

namespace Programa05_Casting
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Considere a seguinte situação:
            float a = 5.4F;
            double b;

            b = a;

            Console.WriteLine("Variavel A = " + a + " e variavel B = " + b);

            // Até ai OK! É possível pois o tipo double possue 8 bytes de armazenamento, e pode guardar os 4 bytes do float
            // PORÉM, a situação inversa já não seria interessante, pois poderia ocorrer PERDA de DADOS
            // É AI QUE ENTRA O CASTING = conversão explícita entre tipos COMPATÍVEIS

            double x = 5.1F;
            float y;

            y = (float)x;

            Console.WriteLine("");
            Console.WriteLine("Variavel X = " + x + " e variavel Y = " + y);

            // Exemplo 02 com perda de informação:

            double m = 5.1;
            int n;

            n = (int)m;

            Console.WriteLine("");
            Console.WriteLine("Variavel M = " + m + " e variavel N = " + n);

            // Exemplo 03 com divisao de inteiros:

            int valor01 = 5, valor02 = 2;
            double resultado = valor01 / valor02; // Nesse caso, o programa entende que o resultado da divisao entre dois int's deve ser int também

            Console.WriteLine("");
            Console.WriteLine("Resultado = " + resultado);

            // Exemplo 04 - divisao de inteiros com CASTING:

            int valor03 = 5, valor04 = 2;
            double resultado02 = (double)valor01 / valor02; // Nesse caso, o programa converte o valor01 para double, e double dividido por int é igual a double

            Console.WriteLine("");
            Console.WriteLine("Resultado = " + resultado02);
        }
    }
}
