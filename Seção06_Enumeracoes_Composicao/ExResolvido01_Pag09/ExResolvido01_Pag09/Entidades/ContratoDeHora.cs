// CLASSE "CONTRATO DE HORAS" PARA RECEBER OS DADOS DO TRABALHADOR

using System;

namespace ExResolvido01_Pag09.Entidades
{
    internal class ContratoDeHora
    {
        // Propriedades
        public DateTime DataDoContrato { get; set; }
        public double ValorPorHora { get; set; }
        public int DuracaoEmHoras { get; set; } // Horas trabalhadas

        // Construtor padrão
        public ContratoDeHora()
        {
        }

        // Contrutor com argumentos
        public ContratoDeHora(DateTime dataDoContrato, double valorPorHora, int duracaoEmHoras)
        {
            DataDoContrato = dataDoContrato;
            ValorPorHora = valorPorHora;
            DuracaoEmHoras = duracaoEmHoras;
        }

        // Método para retornar o valor total do contrato
        public double ValorTotal()
        {
            return DuracaoEmHoras * ValorPorHora;
        }
    }
}
