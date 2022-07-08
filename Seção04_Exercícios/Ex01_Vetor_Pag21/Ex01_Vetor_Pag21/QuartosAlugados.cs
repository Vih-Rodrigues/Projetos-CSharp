namespace Ex01_Vetor_Pag21
{
    internal class QuartosAlugados
    {
        // Propriedades autoimplementadas

        public string Nome { get; set; }
        public string Email { get; set; }
        
        // Construtor

        public QuartosAlugados(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        // Outro método da classe

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
