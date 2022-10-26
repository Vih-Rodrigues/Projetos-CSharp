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

            // Encontra o E - primo em relação a Z
            e = 2;
            bool EprimoZ = false;
            int qtde_divisores = 1; // O 1 já está incluso
            int contador = 0; // Passará por todos os inteiros até o z para cada primo
            bool achouPrimo = false; // booleano para sinalizar cada primo encontrado
            bool NaoExisteEprimoZ = false;
            while (EprimoZ != true && NaoExisteEprimoZ != true)
            {
                while (e <= z && achouPrimo != true)
                {
                    Console.WriteLine("\n\nContagem em: " + e + "\n");

                    if (qtde_divisores <= 2 && contador <= z)
                    {
                        contador++;
                        if (e % contador == 0)
                        {
                            qtde_divisores++;
                        }

                        else if (contador == z && qtde_divisores == 2)
                        {
                            achouPrimo = true;
                        }

                        achouPrimo = false;
                    }

                    else
                    {
                        e++;
                        qtde_divisores = 1;
                        contador = 0;
                        achouPrimo = false;
                    }
                }

                if (achouPrimo == true)
                {
                    // Verifica se E é primo em relação a Z
                    if (Math.Round((double)z % e) == 1) // resultado da divisão = 1,5 -> aproxima para 2 | 1.4 -> aproxima para 1
                    {
                        EprimoZ = true;
                    }

                    else
                    {
                        EprimoZ = false;
                        e++;
                        qtde_divisores = 1;
                        contador = 0;
                        achouPrimo = false;
                    }
                }

                else
                {
                    NaoExisteEprimoZ = true;
                }
            }

            // Apresenta E
            if (NaoExisteEprimoZ == true)
            {
                Console.WriteLine("\nNão existe um número primo E em relação a Z.");
            }

            else
            {
                Console.WriteLine("\nE = " + e + "\n\n");
            }

            // Encontra o D
            d = 0;
            while (resultado != true)
            {
                float auxiliarCalcCripto;

                auxiliarCalcCripto = ((e * d) % z);

                if (Math.Round(auxiliarCalcCripto) == 1)
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
