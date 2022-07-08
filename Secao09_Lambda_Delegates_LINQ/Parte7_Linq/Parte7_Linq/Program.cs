using System;
using System.Linq;

namespace Parte7_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Especificando o data source...
            int[] numeros = new int[] { 1, 2, 3, 4 };

            // Definindo a query...
            var resultado = numeros
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Operação que força a execução da query
            foreach (int objeto in resultado)
            {
                Console.WriteLine(objeto);
            }
        }
    }
}
