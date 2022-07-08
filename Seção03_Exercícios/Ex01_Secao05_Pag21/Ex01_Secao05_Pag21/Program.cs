using System;
using System.Globalization;

namespace Ex01_Secao05_Pag21
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta_main;
            int numero_conta_main, opcao_deposito_inicial;
            string titular_main;
            double deposito_inicial_main, deposito_main, saque_main;



            Console.Write("Entre o número da conta: ");
            numero_conta_main = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            titular_main = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial:\n[1] - Sim\n[2] - Não");
            opcao_deposito_inicial = int.Parse(Console.ReadLine());
            
            // Chamada do construtor com os TRÊS argumentos
            if (opcao_deposito_inicial == 1)
            {
                Console.Write("Entre o valor do depósito inicial: ");
                deposito_inicial_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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
    }
}

