using System.Globalization;

namespace Program04_Estoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
