using System;

namespace Programa04_Atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = 10;
            Console.WriteLine("Variavel X = " + x);
            
            x += 2; // x recebe x + 2
            Console.WriteLine("Variavel X = " + x);

            x -= 2; // x recebe x - 2
            Console.WriteLine("Variavel X = " + x);

            x *= 3; // x recebe x * 3
            Console.WriteLine("Variavel X = " + x);

            x /= 2; // x recebe x / 2
            Console.WriteLine("Variavel X = " + x);

            x %= 2; // x recebe x % 2
            Console.WriteLine("Variavel X = " + x);
            Console.WriteLine("__________________________________");

            // Segunda parte da aula
            
            string letras = "VI";
            Console.WriteLine(letras);

            letras += "TORIA";
            Console.WriteLine(letras);
            Console.WriteLine("__________________________________");

            // Terceira parte da aula

            int a = 10, b = 10;

            a++;
            b--;

            Console.WriteLine("Variavel A = " + a);
            Console.WriteLine("Variavel B = " + b);
            Console.WriteLine("__________________________________");

            // Quarta parte da aula

            int c, d = 10;

            c = d++; // Nesse caso, primeiro o c recebe o d (c passa a valer 10), e depois incrementa o d (d passa a valer 11)

            Console.WriteLine("Variavel C = " + c);
            Console.WriteLine("Variavel D = " + d);
            Console.WriteLine("__________________________________");

            // Quinta parte da aula

            int e, f = 10;

            e = ++f; // Nesse caso, primeiro incrementa o f (f passa a valer 11), e depois o e recebe o f (e passa a valer 11 também)

            Console.WriteLine("Variavel E = " + e);
            Console.WriteLine("Variavel F = " + f);
        }
    }
}
