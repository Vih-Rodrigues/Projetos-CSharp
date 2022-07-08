// CLASSE "DEPARTAMENTO"

namespace ExResolvido01_Pag09.Entidades
{
    internal class Departamento
    {
        // Propriedade
        public string Nome { get; set; }

        // Construtor padrão
        public Departamento()
        {
        }

        // Construtor que recebe Nome como argumento
        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
