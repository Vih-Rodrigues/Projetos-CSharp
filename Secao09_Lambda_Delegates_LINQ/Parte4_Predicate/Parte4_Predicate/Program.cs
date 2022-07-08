/*
DELEGATE PREDICATE - Exemplo com RemoveAll
Fazer um programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo preço mínimo seja R$ 100,00.
*/

using System;
using System.Collections.Generic; // Namespace para uso da lista
using Parte4_Predicate.Entidades;

namespace Parte4_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração e instanciação da lista do tipo Produto
            List<Produto> lista = new List<Produto>();
            
            lista.Add(new Produto("Tv", 900.00));
            lista.Add(new Produto("Mouse", 50.00));
            lista.Add(new Produto("Tablet", 350.50));
            lista.Add(new Produto("HD Case", 80.90));

            // O método "RmoveAll" tem como argumento um PREDICATE (função que recebe um objeto e retorna um booleano)
            lista.RemoveAll(TesteProduto);

            foreach (Produto objProduto in lista)
            {
                Console.WriteLine(objProduto);
            }
        }

        // PREDICATE: Função auxiliar que recebe o produto e devolve um booleano
        public static bool TesteProduto(Produto produtoParametro)
        {
            return produtoParametro.Preco >= 100.00;
        }
    }
}
