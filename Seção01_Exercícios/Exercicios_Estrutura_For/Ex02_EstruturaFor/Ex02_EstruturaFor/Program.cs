/*
    Udemy - curso C# - Seção 03
    Estruturas - laço For

Exercício 02: Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/

using System;

namespace Ex01_EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, valor = 0, dentroIntervalo = 0, foraIntervalo = 0;

            Console.Write("Informe um número inteiro para quantidade de números que serão lidos: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= X; i++)
            {
                Console.Write("\nValor #" + i + " : ");
                valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {
                    dentroIntervalo++;
                }

                else
                {
                    foraIntervalo++;
                }
            }
            
            Console.WriteLine("\nValores in/out -> Intervalo [10, 20]\n" + dentroIntervalo + " in\n" + foraIntervalo + " out");
        }
    }
}