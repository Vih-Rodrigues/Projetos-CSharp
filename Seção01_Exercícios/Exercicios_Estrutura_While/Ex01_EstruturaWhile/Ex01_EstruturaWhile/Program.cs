/*
Udemy - curso C#
Aula 33
Estruturas While
Exercício 01: Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
 */

using System;

namespace Ex01_EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha, entrada;

            Console.Write("Cadastre sua senha: ");
            senha = int.Parse(Console.ReadLine());

            Console.Write("\n\nCarregando...");
            for (int i = 0; i < 999999999; i++)
            {
                // Temporizador
            }

            Console.Clear();

            Console.Write("Informe a senha para entrar: ");
            entrada = int.Parse(Console.ReadLine());
                
            while (entrada != senha)
            {
                Console.WriteLine("\nSenha inválida.\n");

                Console.Write("Informe a senha para entrar: ");
                entrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nAcesso permitido.");
        }
    }
}
