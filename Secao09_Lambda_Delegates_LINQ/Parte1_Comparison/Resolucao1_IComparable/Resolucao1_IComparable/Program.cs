using System;
using System.Collections.Generic;
using Resolucao1_IComparable.Entidades;

namespace Resolucao1_IComparable
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
            // ATENÇÃO: a função "Sort()" só funciona se o tipo da lista (produto) implementar a interface IComparable
            lista.Sort();

            foreach (Produto produto in lista)
            {
                Console.WriteLine(produto);
            }
        }
    }
}