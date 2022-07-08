// CLASSE COMENTARIO

namespace ExResolvido02_Pag12.Entidades
{
    class Comentario
    {
        // Propriedade
        public string Texto { get; set; }

        // Construtores:
        public Comentario()
        {
        }

        public Comentario(string textoParametro)
        {
            Texto = textoParametro;
        }
    }
}
