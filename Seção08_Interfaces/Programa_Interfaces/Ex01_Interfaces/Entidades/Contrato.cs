// CLASSE CONTRATO

using System; // Namespace declarado para o uso do tipo DateTime
using System.Collections.Generic; // Namespace declarado para o uso de lista

namespace Ex01_Interfaces.Entidades
{
    class Contrato
    { 
        // Propriedades autoimplementadas
        public int NumeroContrato { get; set; }
        public DateTime DtaContrato { get; set; }
        public double ValorTotalContrato { get; set; }
        public List<Parcela> Parcelas { get; set; }

        // Construtor
        public Contrato(int numeroContratoParametro, DateTime dtaContratoParametro, double valorTotalContratoParametro)
        {
            NumeroContrato = numeroContratoParametro;
            DtaContrato = dtaContratoParametro;
            ValorTotalContrato = valorTotalContratoParametro;

            Parcelas = new List<Parcela>();
        }

        // Método
        public void AdicionaParcela(Parcela parcelaParametro)
        {
            Parcelas.Add(parcelaParametro);
        }
    }
}
