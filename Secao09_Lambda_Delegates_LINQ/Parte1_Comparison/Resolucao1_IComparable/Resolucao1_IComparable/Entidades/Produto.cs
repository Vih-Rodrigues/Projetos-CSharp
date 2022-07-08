using System;

namespace Resolucao1_IComparable.Entidades
{
    // A classe Produto implementa a interface IComparable (versão genérica = IComparable<Produto>)
    class Produto : IComparable<Produto>
    {
        // Propriedades autoimplementadas
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Construtor
        public Produto(String nomeParametro, Double precoParametro)
        {
            Nome = nomeParametro;
            Preco = precoParametro;
        }

        // Métodos

        // Sobreposição
        public override string ToString()
        {
            return "________\nProduto: " + Nome + "\nPreco: R$ " + Preco.ToString("F2");
        }

        // Método CompareTo 
        public int CompareTo(Produto outroProdutoParametro)
        {
            // retorna nome do produto (convertido para maiusculo), comparando ele com outroProdutoParametro (também convertido para maiusculo)
            return Nome.ToUpper().CompareTo(outroProdutoParametro.Nome.ToUpper());
        }
    }
}