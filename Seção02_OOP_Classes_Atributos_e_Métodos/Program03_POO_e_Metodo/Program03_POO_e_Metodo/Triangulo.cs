// Importação de dependências
using System; // Declaração do System para uso do Math
    
namespace Program03_POO_e_Metodo // Namespace da classe
{
    internal class Triangulo // Nome da classe
    {
        // Atributos da classe | public indica que o atributo ou método pode ser usado em outros arquivos
        public double lado01;
        public double lado02;
        public double lado03;

        // double = tipo do dado que o método retorna + nome do método + lista de parâmetros do método
        public double Area()
        {
            double P, raiz;

            P = (lado01 + lado02 + lado03) / 2.0;

            raiz = Math.Sqrt(P * (P - lado01) * (P - lado02) * (P - lado03));

            return raiz;
        }
    }
}
