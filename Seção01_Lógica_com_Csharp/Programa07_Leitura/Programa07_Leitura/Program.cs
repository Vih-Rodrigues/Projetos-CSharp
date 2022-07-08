using System;

namespace Programa07_Leitura
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            
            Console.WriteLine("Você digitou: " + frase);

            // Segunda parte da aula

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Voce digitou: " + x + " - " + y + " - " + z);
            Console.WriteLine("");

            // Terceira parte da aula - SPLIT

            string frase02 = Console.ReadLine();
            
            string[] vetor = frase02.Split(' '); // comando Split reconhece os espaços e separa as palavras uardando-as no vetor

            string p1 = vetor[0];
            string p2 = vetor[1];   
            string p3 = vetor[2];

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Voce digitou: " + p1 + " " + p2 + " " + p3);
            Console.WriteLine("");

            // Qurta parte da aula - SPLIT

            string[] vetor02 = Console.ReadLine().Split(' ');

            string p4 = vetor[0];
            string p5 = vetor[1];
            string p6 = vetor[2];

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Voce digitou: " + p4 + " " + p5 + " " + p6);
            Console.WriteLine("");
        }
    }
}
