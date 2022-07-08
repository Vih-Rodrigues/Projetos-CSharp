using System.Globalization;

namespace Ex03_secao04_Pag18
{
    internal class Aluno
    {
        public string Nome;
        public double Nota01, Nota02, Nota03;

        public double NotaFinal()
        {
            return Nota01 + Nota02 + Nota03;
        }

        public bool Aprovado()
        {
            string status_aluno;

            if (NotaFinal() >= 60.00)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public double Faltou()
        {
            if (Aprovado())
            {
                return 0.0;
            }

            else
            {
                return 60.00 - NotaFinal();
            }
        }

        public override string ToString()
        {
            return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
