using System.Globalization;

namespace Prog07_AutoProperties
{
    internal class Produto
    {
        // 1º => ATRIBUTOS PRIVATIVOS


        private string _nome; // Como o _nome possui uma lógica particular personalizada, não é recomendado tentar implementá-lo como auto-propertie 
        

        //______________________________________________________________________________________________________________________________________________


        // 2º => PROPRIEDADES AUTOIMPLEMENTADAS


        public double Preco { get; private set; } // PERMITE ACESSAR O DADO, MAS PROIBE A ALTERAÇÃO DESSE DADO
        public int Quantidade { get; private set; }


        //______________________________________________________________________________________________________________________________________________


        // 3º => CONSTRUTORES


        // Construtor PADRÃO -> não possui parâmetros
        public Produto()
        {
        }

        
        // Construtor com os 3 parâmetros
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        //______________________________________________________________________________________________________________________________________________


        // 4º => PROPRIEDADES CUSTOMIZADAS


        // PROPRIEDADE (OU "PROPERTIE") definindo as operações de Get e Set 
        public string Nome
        {
            get { return _nome; }

            set 
            {
                if (value != null && value.Length > 1) // '.Length' = propriedade do string que retorna o tamanho do string
                {
                    _nome = value;
                }
            }
        }


        //______________________________________________________________________________________________________________________________________________


        // 5º => OUTROS MÉTODOS DA CLASSE


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        
        public void AdicionarProdutos(int quantidade) 
        {
            Quantidade += quantidade;
        }

        
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        
        // "override" é utilizada para fazer uma sobreposição
        public override string ToString()
        {
            return "\nProduto: " + _nome
                    + "\nR$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + "\n" + Quantidade + " unidade(s)"
                    + "\nTotal: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
