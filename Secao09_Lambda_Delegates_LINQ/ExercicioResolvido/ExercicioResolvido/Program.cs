/*                   Udemy - curso C#
 *                       Seção 17
 *                  Exercício Resolvido
Fazer um programa para ler um conjunto de produtos a partir de um arquivo em formato .txt (suponha que exista pelo menos um produto).
Em seguida mostrar o preço médio dos produtos. Depois, mostrar os nomes, em ordem decrescente, dos produtos que possuem preço inferior 
ao preço médio.
*/

using System;
using System.Collections.Generic; // Namespace para uso de listas
using System.IO; // Namespace para uso dos comandos "StreamReader" e "File.OpenText()"
using System.Linq; // Namespace para uso do Select e Where
using ExercicioResolvido.Entidades;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;

            Console.Write("Entre o caminho do arquivo: ");
            path = Console.ReadLine();

            // Lista para leitura dos dados no arquivo
            List <Produto> lista = new List<Produto>();

            using (StreamReader streamReader = File.OpenText(path))
            {
                while (!streamReader.EndOfStream) // Enquanto o stream NÃO estiver terminado...
                {
                    string[] vetor;
                    string nome;
                    double preco;
                    
                    vetor = streamReader.ReadLine().Split(" - ");

                    nome = vetor[0];
                    preco = double.Parse(vetor[1]);

                    // Instanciando a lista...
                    lista.Add(new Produto(nome, preco));
                }
            }

            var media = lista.Select(produto => produto.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Média dos preços: R$ " + media.ToString("F2"));

            var nomes = lista.Where(produto => produto.Preco < media).OrderByDescending(produto => produto.Nome).Select(produto => produto.Nome);
            
            // Laço foreach para imprimir o resultado na tela
            foreach (string objetoNome in nomes)
            {
                Console.WriteLine(objetoNome);
            }
        }
    }
}
