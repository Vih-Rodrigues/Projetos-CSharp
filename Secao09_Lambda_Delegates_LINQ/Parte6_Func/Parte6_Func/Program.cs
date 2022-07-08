/*
DELEGATE FUNC - Exemplo com Select
Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista contendo os nomes dos produtos em CAIXA ALTA. 
*/

using System;
using System.Collections.Generic;
using Parte6_Func.Entidade;

// A função Selecet pertence ao namespace System.Linq 
using System.Linq; // "A função Select pega a coleção e tranforma em outra"

namespace Parte6_Func
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

            // A função Select retorna um IEnumerable (uma coleção mais genérica), e o argumento da função select é um Func<Produto, TResult>
            // TResult será definido, neste caso, sendo o retorno das string em caixa alta
            // Como a função Select retorna um IEnumerable, é necessário converter o argumento com ".ToList()"
            List<string> resultado = lista.Select(RetornaNome).ToList();


            /* Sintaxe alternativa: escrevendo um DELEGATE que recebe uma função que, por sua vez, recebe um Produto e retorna uma string
            
            Func<Produto, string> func = RetornaNome;
            List<string> resultado = lista.Select(func).ToList();

            */


            /* Sintaxe alternativa2: expressão LAMBDA
             * Atenção: Nesse caso a função RetornaNome não é necessária!
            
            Func<Produto, string> func = produto => produto.Nome.ToUpper();
            List<string> resultado = lista.Select(func).ToList();

            */


            /* Sintaxe alternativa2: expressão LAMBDA inline
             * Atenção: Nesse caso a função RetornaNome não é necessária!
            
            List<string> resultado = lista.Select(produto => produto.Nome.ToUpper()).ToList();

            */


            foreach (string objString in resultado)
            {
                Console.WriteLine(objString);
            }
        }

        // Função que recebe um produto e retorna o nome do produto em caixa alta na forma de string
        static string RetornaNome(Produto produtoParametro)
        {
            return produtoParametro.Nome.ToUpper();
        }
    }
}
