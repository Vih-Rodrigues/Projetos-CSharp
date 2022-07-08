using System;
using System.Collections.Generic;
using Resolucao4_Lambda.Entidades;

namespace Resolucao4_Lambda
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

            // Declarando um Comparison<Produto> e atribuindo à ele uma declaração de função LAMBDA
            // '=>' é um operador de FUNÇÃO
            Comparison<Produto> comparison = (produto1, produto2) => produto1.Nome.ToUpper().CompareTo(produto2.Nome.ToUpper());

            // ATENÇÃO: também é possível aplicar a expressão LAMBDA diretamente dentro do Sort!
            // -> Expressão lambda inline <-
            // Exemplo: lista.Sort((produto1, produto2) => produto1.Nome.ToUpper().CompareTo(produto2.Nome.ToUpper()));

            // "Sort(Comparison<Produto> comparison)" é um DELEGATE, e portanto, aceita função como referencia
            // Sort recebe o Comparison Produto como argumento...
            lista.Sort(comparison);

            foreach (Produto produto in lista)
            {
                Console.WriteLine(produto);
            }
        }
    }
}