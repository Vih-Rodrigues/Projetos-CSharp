using System.Globalization;

namespace Prog04_This_Referencia
{
    internal class Produto
    {
        // Atributos:
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() // Construtor PADRÃO -> não possui parâmetros
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() // : this() referencia o construtor PADRÃO da classe
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) // : this(nome, preco) referencia o construtor de DUAS REFERÊNCIAS, sendo elas nome e preco, da classe
        {
            Quantidade = quantidade;
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
