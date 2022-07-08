using System;
using System.Collections.Generic;
using System.Text; // Namespace necessário para o uso do STRINGBUILDER

namespace ExResolvido02_Pag12.Entidades
{
    class Publicacao
    {
        // Propriedades auto-implementadas:

        public DateTime Momento { get; set; } // Atributo "Momento" referente ao momento em que a publicação foi feita!
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Curtidas { get; set; }

        // De acordo com a composição dos objetos, é preciso associar a Publicação com os comentários da Classe "Comentario".
        // Quando se tem relação de composição (tem-um tem-muitos), como no caso da publicação, que pode ter muitos comentários, 
        // é preciso declarar na classe Publicação uma ->lista<- de comentários:
        // Propriedade pública do tipo List, que por sua vez é do tipo Comentario. 
        // Nome da lista: Comentarios 
        // Importante: instanciar a lista!
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
    
      
        // Construtores:

        public Publicacao() // -> Construtor padrão
        {
        }

        public Publicacao(DateTime momentoParametro, string tituloParametro, string conteudoParametro, int curtidasParametro)
        {
            Momento = momentoParametro;
            Titulo = tituloParametro;
            Conteudo = conteudoParametro;
            Curtidas = curtidasParametro;
        }


        // Métodos: (por PADRÃO, desenvolve-se os métodos para adicionar e remover os comentários da publicação)

        // Método para adicionar comentários na Publicação:
        public void AdicionaComentario(Comentario comentarioParametro)
        {
            // Adiciona na lista Comentarios o comentario que veio por parâmetro
            Comentarios.Add(comentarioParametro);
        }

        // Método para remover comentários da Publicação:
        public void RemoveComentario(Comentario comentarioParametro)
        {
            // Remove da lista Comentarios o comentario que veio por parâmetro
            Comentarios.Remove(comentarioParametro);
        }


        // Convertendo a publicação para string para poder fazer a impressão da publicação na tela
        // Uso da função StringBuilder para melhor eficiência da execução na máquina, de modo a evitar o processo de concatenação de varias strings
        public override string ToString()
        {
            StringBuilder variavelSB = new StringBuilder();
            variavelSB.AppendLine(Titulo);
            variavelSB.Append(Curtidas);
            variavelSB.Append(" curtidas - ");
            variavelSB.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            variavelSB.AppendLine(Conteudo);
            variavelSB.AppendLine("Comentários:");

            // Laço foreach 'para cada comentario encontrado na lista "Comentarios"..."
            foreach (Comentario comentarioEncontrado in Comentarios)
            {
                variavelSB.AppendLine(comentarioEncontrado.Texto);
            }
            
            return variavelSB.ToString();
        }
    }
}
