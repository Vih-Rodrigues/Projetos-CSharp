// CLASSE SERVICOCONTRATO

using System;
using Ex01_Interfaces.Entidades;

namespace Ex01_Interfaces.Servicos
{
    class ServicoContrato
    {
        // Atributo privativo
        private IServicoPagamento _taxaContrato;

        // Construtor
        public ServicoContrato(IServicoPagamento servicoPagamentoParametro)
        {
            _taxaContrato = servicoPagamentoParametro;
        }

        // Método
        public void CalculoParcelas(Contrato contratoParametro, int mesesParametro)
        {
            // 1º PASSO: declarar uma variável para obter o valor base de cada mes
            double valorBaseParcela;
            
            valorBaseParcela = contratoParametro.ValorTotalContrato / mesesParametro;

            for (int i=1; i <= mesesParametro; i++)
            {
                DateTime data;
                double atualizaValorParcela, valorTotalParcela;           

                data = contratoParametro.DtaContrato.AddMonths(i);
                atualizaValorParcela = valorBaseParcela + _taxaContrato.Juros(valorBaseParcela, i);
                valorTotalParcela = atualizaValorParcela + _taxaContrato.Taxa(atualizaValorParcela);
                contratoParametro.AdicionaParcela(new Parcela(data, valorTotalParcela));
            }
        }
    }
}
