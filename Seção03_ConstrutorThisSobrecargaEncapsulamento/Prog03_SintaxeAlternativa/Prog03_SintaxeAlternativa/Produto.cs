using System.Globalization;

namespace Prog03_SintaxeAlternativa
{
    internal class Produto
    {
        // Atributos:
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            // Construtor PADRÃO -> não possui parâmetros
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Variável de parâmetro de entrada de função inicia com letra minúscula
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade; // OU "Quantidade += quantidade"
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade; // OU "Quantidade -= quantidade"
        }

        // "override" é utilizada para fazer uma sobreposição
        public override string ToString()
        {
            return "\nProduto: " + Nome
                    + "\nR$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + "\n" + Quantidade + " unidade(s)"
                    + "\nTotal: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
