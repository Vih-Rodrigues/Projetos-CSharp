namespace Ex04_secao04_Pag24
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.00;

        public static double ConverteMoeda(double valor_compra, double valor_cotacao)
        {
            double resultado;

            resultado = valor_compra * valor_cotacao;
            
            return resultado + ((resultado * IOF) / 100.00);
        }
    }
}
