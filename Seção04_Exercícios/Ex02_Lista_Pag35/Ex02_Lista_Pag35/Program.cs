/*
                                                Udemy - curdo C#
                                                    Seção 06

                                        Material de apoio - Página 35

Exercício: Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. 
Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abortar a operação. 
Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. 
Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.
*/

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex02_Lista_Pag35
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeFuncionarios;

            List<Funcionario> lista;
            lista = new List<Funcionario>();

            int id_main, id_aumento;
            string nome_main;
            double salario_main, porcentagemAumento;

            Console.Write("Quantos funcionários serão registrados?\n-> ");
            quantidadeFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeFuncionarios; i++)
            {
                Console.Write("\nFuncionário #" + (i+1) + "\nId: ");
                id_main = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                nome_main = Console.ReadLine();

                Console.Write("Salário: ");
                salario_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(id_main, nome_main, salario_main));
            }

            Console.Write("\n\nEntre o id do funcionário o qual você deseja aumentar o salário: ");
            id_aumento = int.Parse(Console.ReadLine());

            Funcionario pesquisaId;
                                    // Quero o objeto 'objeto', TAL QUE 'objeto' no Id seja o id informado para o aumento do salário
            pesquisaId = lista.Find(objeto => objeto.Id == id_aumento);
        
            if (pesquisaId != null)
            {
                Console.Write("\nInforme a porcentagem para o aumento do salário: ");
                porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                pesquisaId.AumentoSalario(porcentagemAumento);
            }

            else
            {
                Console.WriteLine("\nId informado não existe!");
            }

            Console.WriteLine("\n\nLista de funcionários atualizada:");

            // Para cada objeto Funcionario na lista.
            foreach (Funcionario objeto in lista)
            {
                Console.WriteLine(objeto); // Escreva o objeto na tela
            }
        }
    }
}
