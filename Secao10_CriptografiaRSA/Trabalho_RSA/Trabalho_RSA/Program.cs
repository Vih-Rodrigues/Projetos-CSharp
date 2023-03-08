using System;
using Trabalho_RSA.Classes;

namespace Trabalho_RSA
{
    class Program
    {
        public static int[] auxiliar_;
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

            Console.Write("Q: ");
            q = int.Parse(Console.ReadLine());

            n = (p * q);

            z = ((p - 1) * (q - 1));

            Console.WriteLine("\nN = " + n + "\nZ = " + z);

            // Encontra o E - primo em relação a Z
            // um número é primo em relação a outro quando o único divisor em comun deles é o *1*

            // Conta quantos divisores Z tem
            int divisoresContador = 0;
          
            for (int i = 1; i <= z; i++)
            {
                if (z % i == 0)
                {
                    divisoresContador++;
                }
            }

            // Grava os divisores de Z em um vetor
            int[] divisoresZ = new int[divisoresContador];
            int contador = 0;
            
            for (int i = 1; i <= z; i++)
            {
                if (z % i == 0)
                {
                    divisoresZ[contador] = i;
                    contador++;
                }
            }

            // busca o primeiro número que seja primo em relação a Z
            bool achouPrimo = false;
            int numeroAtual = 1;
            
            while (achouPrimo != true)
            {
                // ----- 1º Parte -----
                // Encontra quantos divisores o Numero Atual tem
                numeroAtual++;
                int qtdeDivisoresNumeroAtual = 0;

                for (int i = 1; i <= z; i++)
                {
                    if (numeroAtual % i == 0)
                    {
                        qtdeDivisoresNumeroAtual++;
                    }
                }

                // Grava os divisores do Numero Atual em um vetor
                int[] divisoresNumeroAtual = new int[qtdeDivisoresNumeroAtual];
                contador = 0;

                for (int i = 1; i <= z; i++)
                {
                    if (numeroAtual % i == 0)
                    {
                        divisoresNumeroAtual[contador] = i;
                        contador++;
                    }
                }

                // ----- 2º Parte -----
                // Compara divisores de Z e Numero Atual, desconsiderando o 1
                bool divisorAMais = false;

                for (int i = 1; i < divisoresZ.Length; i++) // vetor Divisores Numero Atual
                {
                    for (int j = 1; j < divisoresNumeroAtual.Length; j++) // vetor Divisores Z
                    {
                        if (divisoresZ[i] == divisoresNumeroAtual[j])
                        {
                            divisorAMais = true;
                        }
                    }
                }

                // Verifica se Z e Numero Atual tem algum divisor em comum além de 1
                if(divisorAMais == true)
                {
                    achouPrimo = false;
                }

                else
                {
                    achouPrimo = true;
                }
            }

            e = numeroAtual;
            Console.WriteLine("\nE = " + e);

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

            // Inicializando a variável antes de entrar no laço
            textoCriptografado = "";

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
                    
                    // recebe vetor com os números
                    textoCriptografado = Criptografar.CriptografarTexto(e, n, texto);

                    Console.WriteLine("\n\nTexto criptografado abaixo:\n\n" + textoCriptografado);
                    Console.ReadLine(); // Pausa
                }

                else if (opcaoMenu == 2)
                {
                    Console.Write("\n\nDigite o texto.\n\n: ");
                    texto = Console.ReadLine();
                    bool textoJaCriptografado = false;
                    
                    if(texto == textoCriptografado)
                    {
                        textoJaCriptografado = true;
                    }

                    textoDescriptografado = Descriptografar.DescriptografarTexto(d, n, texto, textoJaCriptografado);
                    Console.WriteLine("\n\nTexto descriptografado abaixo:\n\n" + textoDescriptografado);
                    Console.ReadLine(); // Pausa
                }

            } while (opcaoMenu != 3);

        }
    }
}
