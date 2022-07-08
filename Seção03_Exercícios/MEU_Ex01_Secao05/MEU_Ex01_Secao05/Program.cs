using System;
using System.Globalization;

namespace Ex01_Secao05_Pag21
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta_main;
            int opcao_menu, numero_conta_main, opcao_deposito_inicial;
            string titular_main, novo_titular_main, auxiliar_numero_conta;
            double deposito_inicial_main, deposito_main, saque_main;

            Console.WriteLine("_____Bem-vindo(a) ao Banco Ocnab!\t=D");
            Console.Write("Opções de acesso:\n[1] - Já sou cliente\n[2] - Desejo abrir uma conta\n-> ");
            opcao_menu = int.Parse(Console.ReadLine());

            if (opcao_menu == 1)
            {
                Console.Write("\nEntre o número da conta: ");
                numero_conta_main = int.Parse(Console.ReadLine());

                Console.Write("Entre o titular da conta: ");
                titular_main = Console.ReadLine();

                Console.WriteLine("\nHaverá depósito inicial:\n[1] - Sim\n[2] - Não");
                opcao_deposito_inicial = int.Parse(Console.ReadLine());

                // Chamada do construtor com os TRÊS argumentos
                if (opcao_deposito_inicial == 1)
                {
                    Console.Write("\nEntre o valor do depósito inicial: ");
                    deposito_inicial_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    auxiliar_numero_conta = ToString(numero_conta_main);

                    conta_main = new ContaBancaria(numero_conta_main, titular_main, deposito_inicial_main);
                }

                // Chamada do construtor com os APENAS DOIS argumentos
                else
                {
                    conta_main = new ContaBancaria(numero_conta_main, titular_main);
                }


                Console.WriteLine("\n-> Dados da conta:\n" + conta_main);


                Console.Write("\nEntre um valor para depósito: ");
                deposito_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta_main.Deposito(deposito_main);


                Console.WriteLine("\n-> Dados da conta atualizados:\n" + conta_main);


                Console.Write("\nEntre um valor para saque: ");
                saque_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta_main.Saque(saque_main);

                Console.WriteLine("\n-> Dados da conta atualizados:\n" + conta_main);
            }

            else
            {
                Console.Clear();
                Console.Write("Obrigada por escolher nosso banco!\t=D\n" +
                                  "O processo de abertura de conta agora é rápido e fácil...\n" + 
                                  "Estamos quase lá!\n\n" + 
                                  "Por favor, informe seu nome completo:\n| ");
                novo_titular_main = Console.ReadLine();

                conta_main = new ContaBancaria(novo_titular_main);

                Console.WriteLine("\n" + novo_titular_main + ", o número da sua nova conta conosco é " + conta_main.NumeroConta);
            }
        }
    }
}
