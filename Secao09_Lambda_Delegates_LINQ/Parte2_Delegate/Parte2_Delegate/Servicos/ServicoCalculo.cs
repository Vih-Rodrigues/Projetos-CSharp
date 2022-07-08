namespace Parte2_Delegate.Servicos
{
    class ServicoCalculo
    {
        public static double Maximo(double x, double y)
        {
            return (x > y) ? x : y;
        }
        public static double Soma(double x, double y)
        {
            return x + y;
        }
        public static double Quadrado(double x)
        {
            return x * x;
        }
    }
}

