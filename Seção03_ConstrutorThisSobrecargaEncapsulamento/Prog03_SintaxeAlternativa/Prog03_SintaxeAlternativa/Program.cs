using System;
using System.Globalization;

namespace Prog03_SintaxeAlternativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto_main, produto_main02, produto_main03; // produto_main02 -> DECLARADO PARA SINTAXE ALTERNATIVA // produto_main03 -> DECLARADO PARA CONSTRUTOR PERSONALIZADO
            int quantidade_adicionais, quantidade_removidos;

            // Variáveis auxiliares do construtor
            string nome_auxiliar;
            double preco_auxiliar;
            int quantidade_auxiliar;

            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome: ");
            nome_auxiliar = Console.ReadLine();

            Console.Write("Preço: ");
            preco_auxiliar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            produto_main = new Produto(); // Chamada do construtor PADRÃO

            // SINTAXE ALTERNATIVA
            produto_main02 = new Produto { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 20 
            };

            // CONSTRUTOR PERSONALIZADO
            produto_main03 = new Produto(nome_auxiliar, preco_auxiliar);

            Console.WriteLine("\nDados do produto: " + produto_main);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            quantidade_adicionais = int.Parse(Console.ReadLine());

            produto_main.AdicionarProdutos(quantidade_adicionais);

            Console.WriteLine("\nDados atualizados: " + produto_main);

            Console.Write("\nDigite o número de produtos a ser retirado do estoque: ");
            quantidade_removidos = int.Parse(Console.ReadLine());

            produto_main.RemoverProdutos(quantidade_removidos);

            Console.WriteLine("\nDados atualizados: " + produto_main);
        }
    }
}