using System;
using System.Globalization;

namespace Program04_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto_main;
            int quantidade_main;

            produto_main = new Produto();

            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome: ");
            produto_main.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto_main.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            produto_main.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + produto_main);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            quantidade_main = int.Parse(Console.ReadLine());

            produto_main.AdicionarProdutos(quantidade_main);

            Console.WriteLine("\nDados atualizados: " + produto_main);

            Console.Write("\nDigite o número de produtos a ser retirado do estoque: ");
            quantidade_main = int.Parse(Console.ReadLine());

            produto_main.RemoverProdutos(quantidade_main);

            Console.WriteLine("\nDados atualizados: " + produto_main);
        }
    }
}
