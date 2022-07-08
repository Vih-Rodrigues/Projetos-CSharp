/*
Udemy - curso C#
Aula 33
Estruturas While
Exercício: Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. 
Escreva um algoritmo para ler o tipo de combustível abastecido, codificado da seguinte forma: 
1.Álcool 
2.Gasolina 
3.Diesel 
4.Fim
Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). 
O programa será encerrado quando o código informado for o número 4. 
Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
*/

using System;

namespace Ex03_EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = 0, contadorAlcool = 0, contadorGasolina = 0, contadorDiesel = 0;

            Console.WriteLine("POSTO DE GASOLINA\nSeja bem-vindo(a)!\nPor favor, informe o tipo de combustível abastecido: ");
            Console.Write("[1] - Álcool\n[2] - Gasolina\n[3] - Diesel\n[4] - Fim/Sair\n\n->");
            entrada = int.Parse(Console.ReadLine());

            while (entrada != 4)
            {
                if (entrada == 1)
                {
                    contadorAlcool++;
                    Console.WriteLine("\nCombustível processado! Obrigada :D");
                }

                else if (entrada == 2)
                {
                    contadorGasolina++;
                    Console.WriteLine("\nCombustível processado! Obrigada :D");
                }

                else if (entrada == 3)
                {
                    contadorDiesel++;
                    Console.WriteLine("\nCombustível processado! Obrigada :D");
                }

                    else
                    {
                        Console.WriteLine("Combustível inválido.");
                    }
                
                Console.WriteLine("\nPOSTO DE GASOLINA\nSeja bem-vindo(a)!\nPor favor, informe o tipo de combustível abastecido: ");
                Console.Write("[1] - Álcool\n[2] - Gasolina\n[3] - Diesel\n[4] - Fim/Sair\n\n->");
                entrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMUITO OBRIGADA\nÁlcool: " + contadorAlcool + "\nGasolina: " + contadorGasolina + "\nDiesel:" + contadorDiesel);
        }
    }
}
