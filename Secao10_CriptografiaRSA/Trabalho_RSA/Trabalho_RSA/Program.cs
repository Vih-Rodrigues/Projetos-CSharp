using System;
using Trabalho_RSA.Classes;

namespace Trabalho_RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q, n, z, d, e, opcaoMenu;
            bool resultado = false;
            string texto, textoCriptografado, textoDescriptografado;

            Console.WriteLine("Sistema de criptografia...\n100% carregado.\n\n\n\t\tBem vindo!\n\n");
            Console.ReadLine(); // Pausa dramática

            Console.Clear();

            Console.WriteLine("Para começar, informe dois números primos, um para ser o P e o outro o Q.\nOBS: Quanto maior o número escolhido mais seguro será o algoritmo!\n\n");

            Console.Write("P: ");
            p = int.Parse(Console.ReadLine());

            Console.Write("\nQ: ");
            q = int.Parse(Console.ReadLine());

            n = (p * q);

            z = ((p - 1) * (q - 1));

            Console.WriteLine("\nN = " + n + "\nZ = " + z);

            Console.Write("\n\nAgora, informe o E, o qual deve ser primo em relação a Z (" + z + ").\nE: ");
            e = int.Parse(Console.ReadLine());

            // Encontra o D
            d = 0;
            while (resultado != true)
            {
                float auxiliar;

                auxiliar = ((e * d) % z);

                if (Math.Round(auxiliar) == 1)
                {
                    resultado = true;
                }

                else
                {
                    resultado = false;
                    d++;
                }
            }

            Console.WriteLine("\nD = " + d + "\n\n");

            do
            {
                // Menu opção cripto ou descripto
                Console.WriteLine("\n\n-------- Menu --------");
                Console.Write("[1] - Criptografar texto\n[2] - Descriptografar texto\n[3] - Sair\n\n> ");
                opcaoMenu = int.Parse(Console.ReadLine());

                if (opcaoMenu == 1)
                {
                    Console.Write("\n\nDigite o texto.\n\n: ");
                    texto = Console.ReadLine();
                    textoCriptografado = Criptografar.CriptografarTexto(e, n, texto);
                    Console.WriteLine("\n\nTexto criptografado abaixo:\n\n" + textoCriptografado);
                    Console.ReadLine(); // Pausa
                }

                else if (opcaoMenu == 2)
                {
                    Console.Write("\n\nDigite o texto.\n\n: ");
                    texto = Console.ReadLine();
                    textoDescriptografado = Descriptografar.DescriptografarTexto(d, n, texto);
                    Console.WriteLine("\n\nTexto descriptografado abaixo:\n\n" + textoDescriptografado);
                    Console.ReadLine(); // Pausa
                }

            } while (opcaoMenu != 3);

        }
    }
}
