using System.Globalization;

namespace Ex01_Secao05_Pag21
{
    internal class ContaBancaria
    {
        // 1º => ATRIBUTOS PRIVATIVOS


        //-------------------------------------------------------------------

        // 2º => PROPRIEDADES AUTOIMPLEMENTADAS

        public int NumeroConta { get; private set; } // Pode ser acessado, mas não pode ser alterado
        public string Titular { get; set; } // Pode ser acessado E alterado
        public double Saldo { get; private set; } // Pode ser acessado MAS somente poderá ser alterado por saque OU depósito

        //-------------------------------------------------------------------

        // 3º => CONSTRUTORES

        public ContaBancaria(int numero_conta, string titular_conta)
        {
            NumeroConta = numero_conta;
            Titular = titular_conta;
        }

        public ContaBancaria(int numero_conta, string titular_conta, double deposito_inicial) : this(numero_conta, titular_conta)
        {
            // Chamada do método DEPÓSITO, passando a quantia depositada por parâmetro
            Deposito(deposito_inicial);
        }

        //-------------------------------------------------------------------


        // 4º => PROPRIEDADES CUSTOMIZADAS


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
            return "Conta: " + NumeroConta + "\n"
                    + "Titular: " + Titular + "\n"
                    + "Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
