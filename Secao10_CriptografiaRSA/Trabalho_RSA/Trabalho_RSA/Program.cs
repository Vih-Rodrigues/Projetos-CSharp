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

            Console.WriteLine("Sistema de criptografia...\n100% carregado.\n\n\n\t\tBem vindo!\n\n\n");
            Console.ReadLine(); // Pausa dramática

            Console.Clear();

            Console.WriteLine("Para começar, informe dois números primos, um para ser o P e o outro o Q.\nOBS: Quanto maior o número escolhido mais seguro será o algoritmo!\n\n");

            Console.WriteLine("P: ");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine("Q: ");
            q = int.Parse(Console.ReadLine());

            n = (p * q);

            z = ((p - 1) * (q - 1));

            Console.WriteLine("\nN = " + n + "\nZ = " + z);

            Console.WriteLine("Agora, informe o D, o qual deve ser primo em relação a Z (" + z + ").\nD: ");
            d = int.Parse(Console.ReadLine());

            // Encontra o E
            e = 0;
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
                    e++;
                }
            }

            // Menu opção cripto ou descripto
            Console.WriteLine("\n\n-------- Menu --------");
            Console.WriteLine("[1] - Criptografar texto\n[2] - Descriptografar texto\n> ");
            opcaoMenu = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o texto.\n\n: ");
            texto = Console.ReadLine();

            switch(opcaoMenu)
            {
                case 1:

                    textoCriptografado = Criptografar.CriptografarTexto(e, n, texto);
                    Console.WriteLine("\n\nTexto criptografado abaixo:\n\n" + textoCriptografado);

                    break;

                case 2:

                    textoDescriptografado = Descriptografar.DescriptografarTexto(d, n, texto);
                    Console.WriteLine("\n\nTexto descriptografado abaixo:\n\n" + textoDescriptografado);

                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        }
    }
}
