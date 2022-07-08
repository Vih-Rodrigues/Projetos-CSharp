using System;
using System.Collections.Generic; // NAMESPACE PARA O USO DE LISTAS

namespace Prog08_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1º PARTE DA AULA - Declarando e instanciando a lista
                               
            // instanciando uma lista vazia
            List<string> lista = new List<string>();

            // instanciando a lista com valores
            //List<string> lista02 = new List<string> { "Maria", "Alex" };

            // 2º PARTE DA AULA - Atribuindo valores à lista com 'Add'
            // Por PADRÃO, o 'Add' adiciona o dado ao final da lista

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine("------------------------------");

            // 2º PARTE DA AULA - Atribuindo valores à lista com Insert
            // O 'Insert' permite especificar qual posição se deseja inserir o dado

            lista.Insert(2, "Marco");
            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine("------------------------------");

            // 3ºPARTE DA AULA - Mostrar o tamanho da lista com Count

            Console.WriteLine("Tamanho da lista: " + lista.Count);
            Console.WriteLine("------------------------------");

            // 4º PARTE DA AULA - Encontrar primeiro elemento da lista com Find 

            // Exemplo: deseja-se encontrar a primeira ocorrencia de um nome que começa com a letra A
            // O Find espera um predicado (função) como argumento
            string primeiro = lista.Find(Teste);

            Console.WriteLine("Primeira ocorrência com 'A': " + primeiro);
            Console.WriteLine("------------------------------");

            // 5º PARTE DA AULA - Encontrando o primeiro com LAMBDA
                                        // Quero o objeto 'x', TAL QUE 'x' na posição zero seja A
            string primeiro02 = lista.Find(x => x[0] == 'M');

            Console.WriteLine("Primeira ocorrência com 'M': " + primeiro02);
            Console.WriteLine("------------------------------");

            // 5º PARTE DA AULA - Encontrar o último elemento da lista com FindLast

            // Exemplo: deseja-se encontrar a última ocorrencia de um nome que começa com a letra A
            string ultimo = lista.FindLast(x => x[0] == 'A');
            
            Console.WriteLine("Última ocorrência com 'A': " + ultimo);
            Console.WriteLine("------------------------------");

            // 6º PARTE DA AULA - Encontrar a primeira POSIÇÃO de elementos da lista com lista.FindIndex

            int posicao = lista.FindIndex(x => x[0] == 'A');

            Console.WriteLine("Primeira posição com 'A': " + posicao);
            Console.WriteLine("------------------------------");

            // 7º PARTE DA AULA - Encontrar a última POSIÇÃO de elementos da lista com lista.FindIndex

            int posicao02 = lista.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("Última posição com 'A': " + posicao02);
            Console.WriteLine("------------------------------");

            // 8º PARTE DA AULA - Filtrar a lista com base e um predicado, nesse caso, a função FindAll

            // Exemplo: Deseja-se filtar, isto é, criar uma nova lista contendo apenas os elementos que
            // satisfaçam o predicado, nesse caso, os nomes que tenham 5 caracteres
            List<string> lista02 = lista.FindAll(x => x.Length == 5);

            Console.WriteLine("Lista 02 com nomes de 5 caracteres da lista 01:");
            // para cada objeto string na lista02...
            foreach (string objeto in lista02)
            {
                Console.WriteLine(objeto); // Mostrar o objeto na tela
            }
            Console.WriteLine("------------------------------");

            // 9º PARTE DA AULA - Remover elementos da lista com:

            // REMOVE

            lista.Remove("Alex");

            Console.WriteLine("Alex removido!\n\nLista atualizada:");
            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto); // Mostrar o objeto na tela
            }
            Console.WriteLine("------------------------------");

            // REMOVEALL

            lista.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("Todos os nomes que começam com M foram removidos!\n\nLista atualizada:");
            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto); // Mostrar o objeto na tela
            }
            Console.WriteLine("------------------------------");

            // REMOVEAT - Remove o elemento pela sua posição

            lista.RemoveAt(1);

            Console.WriteLine("Nome na posição 2 removido!\n\nLista atualizada:");
            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto); // Mostrar o objeto na tela
            }
            Console.WriteLine("------------------------------");

            // REMOVERANGE - Remove os elementos de uma faixa

            List<string> lista03 = new List<string>();

            lista03.Add("Vitoria");
            lista03.Add("Solange");
            lista03.Add("Guilherme");
            lista03.Add("Eduardo");

            Console.WriteLine("Nova lista 03:");
            foreach (string objeto in lista03)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine("------------------------------");

            lista03.RemoveRange(2, 2);

            Console.WriteLine("2 Elementos removidos a partir da posição 2.\n\nLista 03 atualizada:");
            foreach (string objeto in lista03)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine("------------------------------");

        }

        // Predicado para o Find
        // Predicado = função que pega um valor e retornará verdadeiro ou falso conforme a lógica que estiver implementada nessa função
        static bool Teste(string primeiraOcorrencia)
        {
            return primeiraOcorrencia[0] == 'A';
        }
    }
}
