using System;
using System.Globalization;

namespace Prog05_Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto_main = new Produto("TV", 500.00, 10);

            Console.WriteLine("MÉTODOS GET E SET PARA ENCAPSULAMENTO");
            
            Console.WriteLine("\n" + produto_main.GetNome()); // A chamado do método permite acesso ao atributo private

            produto_main.SetNome("TV 4K");
            Console.WriteLine("\n" + produto_main.GetNome());

            produto_main.SetNome("T"); // STRING DE TAMANO = 1 NÃO SERÁ ACEITA
            Console.WriteLine("\n" + produto_main.GetNome());

            Console.WriteLine("\n" + produto_main.GetPreco());

            /*
             * OPERAÇÕES PROIBIDAS POR CODIFICAÇÃO, isto é, não há a possibilidade de alteração desses métodos/atributos
            produto_main.SetPreco(100);
            produto_main.SetQuantidade(5);
            */
        }
    }
}
