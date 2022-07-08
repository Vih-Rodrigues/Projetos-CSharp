/*
Udemy - Curso C#
Estruturas condicionais
Exercício 05: Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
A seguir, calcule e mostre o valor da conta a pagar.
*/

using System;
using System.Globalization;

namespace Ex05_EstruturaCo
{
    class Program
    {
        static void Main(string[] args)
        {
            int controle = 1;
            double codigo = 0, quantidade = 0, total_a_pagar = 0;
            string[] pedidos;

            while (controle != 0)
            {
                Console.WriteLine("CÓDIGO\t\tESPECIFICAÇÃO\t\tPREÇO");
                Console.WriteLine("1\t\tCachorro-quente\t\tR$ 4,00");
                Console.WriteLine("2\t\tX-Salada\t\tR$ 4,50");
                Console.WriteLine("3\t\tX-Bacon\t\t\tR$ 5,00");
                Console.WriteLine("4\t\tTorrada simples\t\tR$ 2,00");
                Console.WriteLine("5\t\tRefrigerente\t\tR$ 1,50");
                Console.WriteLine("\nO que deseja pedir?\nATENÇÃO: informe seu pedido pelo código + espaço + quantidade");
                pedidos = Console.ReadLine().Split(' ');

                codigo = double.Parse(pedidos[0]);
                quantidade = double.Parse(pedidos[1]);

                if (codigo == 1)
                {
                    total_a_pagar = total_a_pagar + (4 * quantidade);
                }

                else if (codigo == 2)
                {
                    total_a_pagar = total_a_pagar + (4.5 * quantidade);
                }

                    else if (codigo == 3)
                    {
                        total_a_pagar = total_a_pagar + (5 * quantidade);
                    }

                        else if (codigo == 4)
                        {
                            total_a_pagar = total_a_pagar + (2 * quantidade);
                        }

                            else
                            {
                                total_a_pagar = total_a_pagar + (1.5 * quantidade);
                            }

                Console.WriteLine("\nDeseja pedir algo mais?\n[1]-Sim\n[0]-Não\n");
                controle = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Total: R$ " + total_a_pagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
