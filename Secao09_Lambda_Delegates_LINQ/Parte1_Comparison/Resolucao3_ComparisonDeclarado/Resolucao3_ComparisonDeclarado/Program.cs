using System;
using System.Collections.Generic;
using Resolucao3_ComparisonDeclarado.Entidades;

namespace Resolucao3_ComparisonDeclarado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lista de produtos...
            List<Produto> lista = new List<Produto>();

            // Adicionando produtos à lista...
            lista.Add(new Produto("TV", 2500.00));
            lista.Add(new Produto("Notebook", 4000.00));
            lista.Add(new Produto("Tablet", 1500.00));

            // Ordenando a lista...

            // Declarando um Comparison<Produto> que recebe o método ComparaProdutos...
            Comparison<Produto> comparison = ComparaProdutos;

            // "Sort(Comparison<Produto> comparison)" é um DELEGATE, e portanto, aceita função como referencia
            // Sort recebe o Comparison Produto como argumento...
            lista.Sort(comparison);

            foreach (Produto produto in lista)
            {
                Console.WriteLine(produto);
            }
        }

        // Método auxiliar para comparar dois produtos
        static int ComparaProdutos(Produto produtoParametro1, Produto produtoParametro2)
        {
            return produtoParametro1.Nome.ToUpper().CompareTo(produtoParametro2.Nome.ToUpper());
        }
    }
}