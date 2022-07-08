using System;

namespace Programa11_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Entre com um número inteiro:");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Ímpar!");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Par!");
            }
        }
    }
}
