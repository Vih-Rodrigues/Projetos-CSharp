using System.Globalization;

namespace Ex02_secao04_Pag17
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        }

        public override string ToString()
        {
            return "Funcionário: " + Nome
                    + "\nSalário: R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
