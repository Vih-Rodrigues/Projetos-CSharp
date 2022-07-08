using System;
using System.Globalization;

namespace Prog06_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto_main = new Produto("TV", 500.00, 10);

            Console.WriteLine("MÉTODOS GET E SET PARA ENCAPSULAMENTO");

            Console.WriteLine("\n" + produto_main.Nome); // A chamado do método permite acesso ao atributo private

            // ALTERAÇÃO NO CÓDIGO -> agora é possível alterar o dado de uma forma mais limpa e "amigável"
            
            produto_main.Nome = "TV 4K";
            Console.WriteLine("\n" + produto_main.Nome);

            produto_main.Nome = "T"; // STRING DE TAMANO = 1 NÃO SERÁ ACEITA
            Console.WriteLine("\n" + produto_main.Nome);

            Console.WriteLine("\n" + produto_main.Preco);
        }
    }
}

