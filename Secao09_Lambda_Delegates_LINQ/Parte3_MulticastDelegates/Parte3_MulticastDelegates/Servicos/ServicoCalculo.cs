using System;
namespace Parte3_MulticastDelegates.Servicos
{
    class ServicoCalculo
    {
        // FUNÇÕES VOID!

        public static void ApresentaMaximo(double x, double y)
        {
            // Se x for maior que y, "return x", senão (falso), "return y"
            double max = (x > y) ? x : y;
            Console.WriteLine("\nMaximo: " + max);
        }
        
        public static void ApresentaSoma(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("\nSoma: " + sum);
        }
    }
}

