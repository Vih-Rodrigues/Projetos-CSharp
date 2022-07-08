// INTERFACE ISERVICOPAGAMENTO

namespace Ex01_Interfaces.Servicos
{
    interface IServicoPagamento
    {
        double Taxa(double valorBaseParametro);
        double Juros(double valorBaseParametro, double mesParametro);
    }
}
