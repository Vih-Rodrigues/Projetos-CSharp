// CLASSE SERVICOPAYPAL

namespace Ex01_Interfaces.Servicos
{
    class ServicoPaypal : IServicoPagamento
    {
        // Atributos privativos - constantes
        private const double TaxaFixa = 0.02;
        private const double JurosSimples = 0.01;

        // Métodos
        public double Juros(double valorBaseParametro, double mesParametro)
        { 
            return valorBaseParametro * JurosSimples * mesParametro;
        }

        public double Taxa(double valorBaseParametro)
        {
            return valorBaseParametro * TaxaFixa;
        }
    }
}
