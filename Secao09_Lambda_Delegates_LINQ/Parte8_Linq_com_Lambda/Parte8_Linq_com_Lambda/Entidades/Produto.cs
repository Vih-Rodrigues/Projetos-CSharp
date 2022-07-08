namespace Parte8_Linq_com_Lambda.Entidades
{
    class Produto
    {
        // Propriedades autoimplementadas
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria CategoriaProduto { get; set; }

        // Sobreposição
        public override string ToString()
        {
            return "\nId: " + Id +
                "\nProduto: " + Nome +
                "\nPreco: R$ " + Preco.ToString("F2") +
                "\nCategoria: " + CategoriaProduto.Nome +
                "\nClassificação: " + CategoriaProduto.Classificacao;
        }
    }
}
