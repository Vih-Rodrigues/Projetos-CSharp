/*
                                    Udemy - curso C#
                                        Seção 9
Página 09

Exercício: Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar 
do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo 
(próxima página).
*/

// PROGRAMA PRINCIPAL

using System;
using ExResolvido01_Pag09.Entidades;
using ExResolvido01_Pag09.Entidades.Enumerados;

namespace ExResolvido01_Pag09
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDepartamento, nomeFuncionario;
            ClassificacaoTrabalhador classificacao;
            double salarioBase;

            Console.Write("Informe o nome do departamento: ");
            nomeDepartamento = Console.ReadLine();

            Console.WriteLine("\n-> Entre com os dados do trabalhador <-");
            Console.Write("\nNome: ");
            nomeFuncionario = Console.ReadLine();

            Console.Write("Classificação (Junior/Intermediario/Senior): ");
            classificacao = Enum.Parse<ClassificacaoTrabalhador>(Console.ReadLine());

            Console.Write("Salário base: R$ ");
            salarioBase = double.Parse(Console.ReadLine());


            // Instanciando os objetos!!

            Departamento departamento = new Departamento(nomeDepartamento);

            Trabalhador trabalhador = new Trabalhador(nomeFuncionario, classificacao, salarioBase, departamento);


            // Pedindo dados de contratos

            int quantContratos, horasTrabalhadas;
            DateTime data;
            double valorPorHora;

            Console.Write("\nQuantidade de contratos para " + nomeFuncionario + ": ");
            quantContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantContratos; i++)
            {
                Console.WriteLine("\n-> Entre com os dados do contrato nº" + i + " <-");
                Console.Write("Data (DD/MM/AAAA): ");
                data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: R$ ");
                valorPorHora = double.Parse(Console.ReadLine());

                Console.Write("Duração (horas): ");
                horasTrabalhadas = int.Parse(Console.ReadLine());

                // Instanciando o Contrato

                ContratoDeHora contrato = new ContratoDeHora(data, valorPorHora, horasTrabalhadas);

                // Adicionando contrato no Trabalhador pela chamada do método "AdicionaContrato"

                trabalhador.AdicionaContrato(contrato);
            }


            // Pedindo mes e ano para calcular ganho

            string mesEAno;
            int mes, ano;

            Console.Write("\n\nEntre com mês e ano para calcular o ganho (MM/AAAA): ");
            mesEAno = Console.ReadLine();

            mes = int.Parse(mesEAno.Substring(0, 2)); // a função Substring recorta 2 posições da string mesEAno, partindo da posição posição 0

            ano = int.Parse(mesEAno.Substring(3)); // a função Substring recorta todas posições da string mesEAno, partindo da posição posição 3


            // Apresentando os dados finais

            Console.WriteLine("\nNome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Renda de " + mesEAno + ": R$ " + trabalhador.Renda(ano, mes).ToString("F2"));
        }
    }
}