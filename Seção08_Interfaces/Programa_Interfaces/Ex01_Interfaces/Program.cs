/*
        Udemy - Curso C# - Seção 14 - Exercício página 11 

                    -> Programa Principal <-
*/

using System;
using System.Globalization;
using Ex01_Interfaces.Entidades;
using Ex01_Interfaces.Servicos;

namespace Ex01_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroContratoMain, quantidadeParcelasMain;
            DateTime dtaContratoMain;
            double valorContratoMain;

            Console.WriteLine("-> Entre com os dados do contrato. <-");
            Console.Write("\nNúmero do contrato: ");
            numeroContratoMain = int.Parse(Console.ReadLine());

            Console.Write("Data (dd/MM/aaaa): ");
            dtaContratoMain = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor total do contrato: R$ ");
            valorContratoMain = double.Parse(Console.ReadLine());
            
            Console.Write("Número total de parcelas: ");
            quantidadeParcelasMain = int.Parse(Console.ReadLine());

            // Instanciando 
            Contrato contratoMain = new Contrato(numeroContratoMain, dtaContratoMain, valorContratoMain);

            ServicoContrato servicoContratoMain = new ServicoContrato(new ServicoPaypal());
            servicoContratoMain.CalculoParcelas(contratoMain, quantidadeParcelasMain);

            Console.WriteLine("\n\nParcelas geradas com sucesso!");
            Console.WriteLine("Parcelas:");
            foreach (Parcela parcela in contratoMain.Parcelas)
            {
                Console.WriteLine(parcela);
            }
        }
    }
}
