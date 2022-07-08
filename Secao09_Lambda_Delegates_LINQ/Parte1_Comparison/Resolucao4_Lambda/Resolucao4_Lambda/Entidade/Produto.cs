using System;

namespace Resolucao4_Lambda.Entidades
{
    // A classe Produto implementa a interface IComparable (versão genérica = IComparable<Produto>)
    class Produto
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
    }
}