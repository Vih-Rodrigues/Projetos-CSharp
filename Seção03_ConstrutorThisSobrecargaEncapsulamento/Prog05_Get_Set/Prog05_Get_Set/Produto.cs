using System.Globalization;

namespace Prog05_Get_Set
{
    internal class Produto
    {
        // Atributos privativos -> não podem ser acessados por outras classes
        // por PADRÃO, os atributos privativos começam com 'underline' e letra minúscula
        private string _nome;
        private double _preco;
        private int _quantidade;

        // Construtor PADRÃO -> não possui parâmetros
        public Produto() 
        {
        }

        // Construtor com os 3 parâmetros
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // MÉTODO PARA OBTER NOME DO PRODUTO
        public string GetNome()
        {
            return _nome;
        }

        // MÉTODO PARA ALTERAR NOME DO PRODUTO
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) // '.Length' = propriedade do string que retorna o tamanho do string
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        // Variável de parâmetro de entrada de função inicia com letra minúscula
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade; 
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade; 
        }

        // "override" é utilizada para fazer uma sobreposição
        public override string ToString()
        {
            return "\nProduto: " + _nome
                    + "\nR$ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
                    + "\n" + _quantidade + " unidade(s)"
                    + "\nTotal: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
