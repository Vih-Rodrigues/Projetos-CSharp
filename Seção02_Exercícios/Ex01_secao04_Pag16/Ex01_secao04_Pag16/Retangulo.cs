using System;

namespace Ex01_secao04_Pag16
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal;

            // diagonal = raiz quadrada de largura² + altura²
            diagonal = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            return diagonal;
        }
    }
}
