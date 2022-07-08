using System;
using System.Globalization;

namespace Prog02_Estoque_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto_main;
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

            // Chamada da classe passando os parâmetros obrigatórios para o SEGUNDO construtor na classe
            produto_main = new Produto(nome_auxiliar, preco_auxiliar);

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
