// CLASSE PARCELA

using System; // Namespace declarado para o uso do tipo DateTime

namespace Ex01_Interfaces.Entidades
{
    class Parcela
    {
        // Propriedades autoimplementadas
        public DateTime DtaParcela { get; set; }
        public double QuantidadeParcelas { get; set; }

        // Construtor
        public Parcela(DateTime dtaParcelaParametro, double quantidadeParcelasParametro)
        {
            DtaParcela = dtaParcelaParametro;
            QuantidadeParcelas = quantidadeParcelasParametro;
        }

        // Sobreposição
        public override string ToString()
        {
            return DtaParcela.ToString("dd/MM/yyyy") + " - " + QuantidadeParcelas.ToString("F2");
        }
    }
}
