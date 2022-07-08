using System.Globalization;

namespace Prog01_Estoque_Construtor
{
    internal class Produto
    {
        // Atributos:
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Constutor: (operação que tem o mesmo nome da classe)
        public Produto(string nome, double preco, int quantidade) // Nome de parâmetro começa com letra minúscula
        {
            // Atribuindo os dados chegados pelo parâmetro para dos atributos da classe
            Nome = nome;
            Preco = preco;
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
