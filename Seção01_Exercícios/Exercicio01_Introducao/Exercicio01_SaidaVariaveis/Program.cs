using System;
using System.Globalization;

namespace Exercicio01_SaidaVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto01 = "Computador";
            string produto02 = "mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco01 = 2100.0;
            double preco02 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto01 + ", cujo valor é $ " + preco01);
            Console.WriteLine(produto02 + ", cujo produto é $ " + preco02);
            Console.WriteLine("");
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine("");
            Console.WriteLine("Medida com oito casas decimais: " + medida);
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}