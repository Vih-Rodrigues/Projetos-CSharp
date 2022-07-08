using System.Globalization;

namespace Ex02_Lista_Pag35
{
    internal class Funcionario
    {
        // Propriedades autoimplementadas
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        // Construtor
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        // Métodos

        // função void para receber e calcular o aumento do salario
        public void AumentoSalario (double porcentagem)
        {
            Salario = Salario + ((Salario * porcentagem) / 100);
        }

        // "override" é utilizada para fazer uma sobreposição
        public override string ToString()
        {
            return "Funcionário " + Id + "     -     Nome: " + Nome + "\t\t-\tSalario: $" + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
