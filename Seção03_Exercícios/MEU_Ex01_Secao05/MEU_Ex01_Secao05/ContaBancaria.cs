using System.Globalization;

namespace Ex01_Secao05_Pag21
{
    internal class ContaBancaria
    {
        // 1º => ATRIBUTOS PRIVATIVOS

        private int _numero_conta;

        //-------------------------------------------------------------------

        // 2º => PROPRIEDADES AUTOIMPLEMENTADAS

        public string Titular { get; set; } // Pode ser acessado E alterado
        public double Saldo { get; private set; } // Pode ser acessado MAS somente poderá ser alterado por saque OU depósito

        //-------------------------------------------------------------------

        // 3º => CONSTRUTORES

        public ContaBancaria(int numero_conta, string titular_conta)
        {
            _numero_conta = numero_conta;
            Titular = titular_conta;
        }

        public ContaBancaria(int numero_conta, string titular_conta, double deposito_inicial) : this(numero_conta, titular_conta)
        {
            // Chamada do método DEPÓSITO, passando a quantia depositada por parâmetro
            Deposito(deposito_inicial);
        }

        public ContaBancaria(string novoTitular)
        {
            Titular = novoTitular;

            Random NumeroConta = new Random();
        }

        //-------------------------------------------------------------------

        // 4º => PROPRIEDADES CUSTOMIZADAS

        public int NumeroConta
        {
            get { return _numero_conta; }

            set 
            {
                if (value / 10000 < 0)
                {
                    _numero_conta = value;
                }
            }
        }

        //-------------------------------------------------------------------

        // 5º => OUTROS MÉTODOS DA CLASSE

        public void Deposito(double quantia)
        {
            Saldo += quantia; // Saldo recebe o que estiver nele + a quantia que foi depositada
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia; // Desconto da quantia
            Saldo -= 5.00; // Desconto da taixa
        }

        public override string ToString()
        {
            return "Conta: " + _numero_conta + "\n"
                    + "Titular: " + Titular + "\n"
                    + "Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}