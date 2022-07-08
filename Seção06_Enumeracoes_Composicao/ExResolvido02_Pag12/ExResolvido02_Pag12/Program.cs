/*
                                            Udemy
                                Curso C# Seção 09 - Aula 122
Exercício Resolvido 2 - Página 12:
"Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do terminal, conforme exemplo."
*/

// PROGRAMA PRINCIPAL

using System;
using ExResolvido02_Pag12.Entidades;

namespace ExResolvido02_Pag12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando as publicações de exemplo:

            // PUBLICAÇÃO 01

            // 1º PASSO: Instanciar os dois comentários feitos no exemplo:
            Comentario comentarioMain01, comentarioMain02;

            comentarioMain01 = new Comentario("Faça uma ótima viagem.");
            comentarioMain02 = new Comentario("Show de bola!");

            // 2º PASSO: Instanciar o post 01
            Publicacao publicacaoMain01 = new Publicacao(
                DateTime.Parse("21/06/2018 13:05:44"), // parametro string convertido para data
                "Viajando para a Nova Zelandia",
                "Estou indo visitar esse maravilhoso país!",
                12);

            // 3º PASSO: Adicionando os comentários ao post
            publicacaoMain01.AdicionaComentario(comentarioMain01);
            publicacaoMain01.AdicionaComentario(comentarioMain02);


            // PUBLICAÇÃO 02
            
            // 1º PASSO: Instanciar os dois comentários feitos no exemplo:
            Comentario comentarioMain03, comentarioMain04;

            comentarioMain03 = new Comentario("Boa noite.");
            comentarioMain04 = new Comentario("Que a força esteja com vc.");

            // 2º PASSO: Instanciar o post 02
            Publicacao publicacaoMain02 = new Publicacao(
                DateTime.Parse("28/07/2018 23:14:19"), // parametro string convertido para data
                "Boa noite pessoal",
                "Vejo vcs amanhã.",
                5);

            // 3º PASSO: Adicionando os comentários ao post
            publicacaoMain02.AdicionaComentario(comentarioMain03);
            publicacaoMain02.AdicionaComentario(comentarioMain04);


            // Imprimindo as publicações na tela:
            
            Console.WriteLine(publicacaoMain01);
            Console.WriteLine(publicacaoMain02);
        }
    }
}
