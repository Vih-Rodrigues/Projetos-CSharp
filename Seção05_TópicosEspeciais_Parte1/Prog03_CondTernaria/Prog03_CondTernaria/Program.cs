using System;

namespace Pro03_CondTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, desconto;

            Console.Write("Digite um valor: R$ ");
            preco = double.Parse(Console.ReadLine());
            
            // Expressão condicional ternária
            //         Condição 'se' ? valor se verdade : valor se falso
            
            //         Se preco < 20   desconto = 10%  desconto = 50%
            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            preco = preco - desconto;

            Console.WriteLine("\nValor total: R$ " + preco + "\nDesconto de R$ " + desconto);
        }
    }
}
