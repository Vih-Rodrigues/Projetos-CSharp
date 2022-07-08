using System;
using System.Collections.Generic;
using Resolucao2_Delegate.Entidades;

namespace Resolucao2_Delegate
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
            // ATENÇÃO: "Sort(Comparison<Produto> comparison)" é um DELEGATE (isto é, aceita função referencia)
            // Nesse caso, o delegate recebe um Comparison Produto como argumento
            // O método auxiliar ComparaProdutos retorna exatamente o que o método pede
            lista.Sort(ComparaProdutos);

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

