/*
DELEGATE ACTION - Exemplo com ForEach
Fazer um programa que, a partir de uma lista de produtos, aumente o preço dos produtos em 10%.
*/

using System;
using System.Collections.Generic; // Namespace para uso de lista
using Parte5_Action.Entidades;

namespace Parte5_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração e instanciação da lista
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("Tv", 900.00));
            lista.Add(new Produto("Mouse", 50.00));
            lista.Add(new Produto("Tablet", 350.50));
            lista.Add(new Produto("HD Case", 80.90));

            // A função ForEach recebe um ACTION do tipo Produto, isto é, recebe uma função void que recebe um Produto
            lista.ForEach(AtualizaPreco);


            /* Sintaxe alternativa:
            
            Action<Produto> action = AtualizaProduto;
            lista.ForEach(action);
            
            */


            /* Sintaxe alternativa 2: expressão LAMBDA + sem função auxiliar
            
            Action<Produto> action = produto => { produto.Preco = produto.Preco + (produto.Preco * 0.1); }; 
            lista.ForEach(action);

            Atenção: Na expressão lambda, o abre e fecha chaves indica que a função tem um corpo mas não retorna nada! 
            */


            /* Sintaxe alternativa 3: expressão LAMBDA inline + sem função auxiliar
            
            lista.ForEach(produto => { produto.Preco = produto.Preco + (produto.Preco * 0.1); });

            */

            foreach (Produto objProduto in lista)
            {
                Console.WriteLine(objProduto);
            }
        }

        // Função auxiliar void que recebe um argumento e não retorna nada
        static void AtualizaPreco(Produto produtoParametro)
        {
            produtoParametro.Preco = produtoParametro.Preco + (produtoParametro.Preco * 0.1);
        }
    }
}
