namespace ExercicioResolvido.Entidades
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
    }
}
