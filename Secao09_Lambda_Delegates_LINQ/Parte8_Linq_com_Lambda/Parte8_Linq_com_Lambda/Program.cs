using System;
using System.Collections.Generic;
using System.Linq;
using Parte8_Linq_com_Lambda.Entidades;

namespace Parte8_Linq_com_Lambda
{
    class Program
    {
        // Função auxiliar
        static void Imprimir<T>(string mensagem, IEnumerable<T> colecao)
        {
            Console.WriteLine(mensagem);
            foreach (T objeto in colecao)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Categoria categoriaMain1 = new Categoria() { Id = 1, Nome = "Ferramentas", Classificacao = 2 };
            Categoria categoriaMain2 = new Categoria() { Id = 2, Nome = "Computadores", Classificacao = 1 };
            Categoria categoriaMain3 = new Categoria() { Id = 3, Nome = "Eletrodomesticos", Classificacao = 1 };

            List<Produto> produtos = new List<Produto>()
            {
                new Produto() { Id = 1, Nome = "Computador", Preco = 1100.00, CategoriaProduto = categoriaMain2 },
                new Produto() { Id = 2, Nome = "Martelo", Preco = 90.00, CategoriaProduto = categoriaMain1 },
                new Produto() { Id = 3, Nome = "TV", Preco = 1700.00, CategoriaProduto = categoriaMain3 },
                new Produto() { Id = 4, Nome = "Notebook", Preco = 1300.00, CategoriaProduto = categoriaMain2 },
                new Produto() { Id = 5, Nome = "Pregos", Preco = 80.00, CategoriaProduto = categoriaMain1 },
                new Produto() { Id = 6, Nome = "Tablet", Preco = 700.00, CategoriaProduto = categoriaMain2 },
                new Produto() { Id = 7, Nome = "Camera", Preco = 700.00, CategoriaProduto = categoriaMain3 },
                new Produto() { Id = 8, Nome = "Impressora", Preco = 350.00, CategoriaProduto = categoriaMain3 },
                new Produto() { Id = 9, Nome = "MacBook", Preco = 1800.00, CategoriaProduto = categoriaMain2 },
                new Produto() { Id = 10, Nome = "Microondas", Preco = 700.00, CategoriaProduto = categoriaMain3 },
                new Produto() { Id = 11, Nome = "Parafusos", Preco = 70.00, CategoriaProduto = categoriaMain1 }
            };

            // resultado1 recebe a lista "produtos" onde...
            var resultado1 = produtos.Where(produto => produto.CategoriaProduto.Classificacao == 1 && produto.Preco < 900.00);
            Imprimir("Classificação 1 - Valor < R$ 900,00 :", resultado1);

            Console.WriteLine("--------------------------------------------------------");

            var resultado2 = produtos.Where(produto => produto.CategoriaProduto.Nome == "Ferramentas" ).Select(produtoSelect => produtoSelect.Nome);
            Imprimir("\n\nNomes dos produtos da categoria: Ferramentas", resultado2);

            Console.WriteLine("--------------------------------------------------------");

            var resultado3 = produtos.Where(produto => produto.Nome[0] == 'C').Select(produtoSelect => new { produtoSelect.Nome, produtoSelect.Preco, NomeCategoria = produtoSelect.CategoriaProduto.Nome });
            Imprimir("\n\nNomes dos produtos começados em 'C' e objetos anonimos:", resultado3);

            Console.WriteLine("--------------------------------------------------------");

            var resultado4 = produtos.Where(produto => produto.CategoriaProduto.Classificacao == 1).OrderBy(produtoOrderBy => produtoOrderBy.Preco).ThenBy(produtoThenBy => produtoThenBy.Nome);
            Imprimir("\n\nProdutos com classificação = 1:", resultado4);

            Console.WriteLine("--------------------------------------------------------");

            // SKIP pula os 2 primeiros e TAKE pega 4 elementos
            var resultado5 = resultado4.Skip(2).Take(4);
            Imprimir("\n\nProdutos com classificação = 1 SKIP 2 TAKE 4:", resultado5);

            Console.WriteLine("--------------------------------------------------------");

            // SKIP pula os 2 primeiros e TAKE pega 4 elementos
            var resultado6 = produtos.First();
            Console.WriteLine("\n\n-> Primeiro teste - First <-\n" + resultado6);

            Console.WriteLine("\n--------------------------------------------------------");

            /* O que acontece se tenta chamar um método First num retorno VAZIO...
             * Nesse caso, não será encontrado um produto com preço maior que 3000.00 o que resultará em uma excessão...
            var resultado7 = produtos.Where(produto => produto.Preco > 3000.00).First();
            Console.WriteLine("\n\n-> Segundo teste <-\n" + resultado7); */

            // Por isso deve-se usar o FirstOrDefault
            var resultado7 = produtos.Where(produto => produto.Preco > 3000.00).FirstOrDefault();
            Console.WriteLine("\n\n-> Segundo teste - FirstOrDefault <-\n" + resultado7);

            Console.WriteLine("\n--------------------------------------------------------");

            // O SingleOrDefault deve ser usado SOMENTE quando se souber ao certo o que será pesquisado (nesse caso, o ID), não podendo escrever "produto.Id > 3", por exemplo
            var resultado8 = produtos.Where(produto => produto.Id == 3).SingleOrDefault();
            Console.WriteLine("\n\nPrimeira busca por ID - SingleOrDefault:\n" + resultado8);

            Console.WriteLine("\n--------------------------------------------------------");

            // Nesse caso não será encontrado um Id igual a 30 e retornará nulo
            var resultado9 = produtos.Where(produto => produto.Id == 30).SingleOrDefault();
            Console.WriteLine("\n\nSegunda busca por ID - SingleOrDefault:\n" + resultado9);

            Console.WriteLine("\n--------------------------------------------------------");

            // Max retorna o maximo da lista, filtrado pelos preços atraves da expressão lambda
            var resultado10 = produtos.Max(produto => produto.Preco);
            Console.WriteLine("\n\nPreço máximo: R$ " + resultado10);

            Console.WriteLine("\n--------------------------------------------------------");

            // Min retorna o minimo da lista, filtrado pelos preços atraves da expressão lambda
            var resultado11 = produtos.Min(produto => produto.Preco);
            Console.WriteLine("\n\nPreço mínimo: R$ " + resultado11);

            Console.WriteLine("\n--------------------------------------------------------");

            var resultado12 = produtos.Where(produto => produto.CategoriaProduto.Id == 1).Sum(produto => produto.Preco);
            Console.WriteLine("\n\nSoma dos preços dos produtos da categoria 1: R$ " + resultado12);

            Console.WriteLine("\n--------------------------------------------------------");

            var resultado13 = produtos.Where(produto => produto.CategoriaProduto.Id == 1).Average(produto => produto.Preco);
            Console.WriteLine("\n\nMédia de preços dos produtos da categoria 1: R$ " + resultado13);

            Console.WriteLine("\n--------------------------------------------------------");

            // Selecione os produtos cujo ID = 5 - Filtra pelos preços - DefaultltIfEmpty = "se o resultado da query for nulo/zero, retrnar 0.00" - faça a divisão...
            var resultado14 = produtos.Where(produto => produto.CategoriaProduto.Id == 5).Select(produto => produto.Preco).DefaultIfEmpty(0.00).Average();
            Console.WriteLine("\n\nMédia de preços dos produtos da categoria 5 - DefaultltIfEmpty: R$ " + resultado14);

            Console.WriteLine("\n--------------------------------------------------------");

            // Criando um cálculo próprio/SOMA PERSONALIZADA... AGREGATE
            var resultado15 = produtos.Where(produto => produto.CategoriaProduto.Id == 1).Select(produto => produto.Preco).Aggregate((x, y) => x + y);
            Console.WriteLine("\n\nSoma personalizada dos preços da categoria 1: R$ " + resultado15);

            Console.WriteLine("\n--------------------------------------------------------");

            // AGREGATE quando o retorno é NULO
            var resultado16 = produtos.Where(produto => produto.CategoriaProduto.Id == 5).Select(produto => produto.Preco).Aggregate(0.00, ((x, y) => x + y));
            Console.WriteLine("\n\nSoma personalizada dos preços da categoria 5 (não existe): R$ " + resultado16);

            Console.WriteLine("\n--------------------------------------------------------");

            // Operação de agrupamento por categoria, por meio do GROUP BY
            var resultado17 = produtos.GroupBy(produto => produto.CategoriaProduto);
            
            // Percorrendo os elementos do resultado17, que são do tipo IGrouping<Categoria, Produto>
            foreach (IGrouping<Categoria, Produto> grupo in resultado17)
            {
                Console.WriteLine("\n\nCategoria - " + grupo.Key.Nome + ":");
                
                foreach (Produto objetoProduto in grupo)
                {
                    Console.WriteLine(objetoProduto);
                }
            }
        }
    }
}
