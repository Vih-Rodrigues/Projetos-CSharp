namespace Parte6_Func.Entidade
{
    class Produto
    {
        // Propriedades autoimplementadas
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Construtor
        public Produto(string nomeParametro, double precoParametro)
        {
            Nome = nomeParametro;
            Preco = precoParametro;
        }

        // Sobreposição
        public override string ToString()
        {
            return "\n" + Nome + " - R$ " + Preco.ToString("F2");
        }
    }
}
