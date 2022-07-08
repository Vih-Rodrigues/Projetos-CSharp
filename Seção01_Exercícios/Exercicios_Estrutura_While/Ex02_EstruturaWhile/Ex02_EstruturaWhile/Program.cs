/*
Udemy - curso C#
Aula 33
Estruturas While
Exercício 02: Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
*/

using System;
using System.Globalization;

namespace Ex02_EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas;
            double x, y;

            Console.WriteLine("\t   _P_L_A_N_O_\n\n");
            Console.WriteLine("\t\tY");
            Console.WriteLine("\t\t|\t");
            Console.WriteLine("\tQ2\t|\tQ1");
            Console.WriteLine("\t\t|\t");
            Console.WriteLine("\t----------------- X");
            Console.WriteLine("\t\t|\t");
            Console.WriteLine("\tQ3\t|\tQ4");
            Console.WriteLine("\t\t|\t");
            
            Console.Write("\n\nInforme as coordenadas de x e y:\nAtenção: utilize espaço para separar os numeros (exemplo: '4.5 -2.2').\n-> ");
            coordenadas = Console.ReadLine().Split(' ');

            x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            while (x != 0.0 && y != 0.0)
            {
                if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("Q1.");
                }

                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("Q2.");
                }

                    else if (x < 0.0 && y < 0.0)
                    {
                        Console.WriteLine("Q3.");
                    }

                        else
                        {
                            Console.WriteLine("Q4.");
                        }

                Console.WriteLine("\n\nInforme as coordenadas de x e y:");
                coordenadas = Console.ReadLine().Split(' ');

                x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
                y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);
            }
            Console.WriteLine("");
        }
    }
}
