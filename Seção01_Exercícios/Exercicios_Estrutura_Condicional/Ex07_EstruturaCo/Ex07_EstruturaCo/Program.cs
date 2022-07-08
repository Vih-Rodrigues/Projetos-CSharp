/*
Udemy - Curso C#
Estruturas condicionais
Exercício 07: Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
*/

using System;
using System.Globalization;

namespace Ex07_EstruturaCo
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
            Console.WriteLine("\n\nInforme as coordenadas de x e y:\nAtenção: utilize espaço para separar os numeros (exemplo: '4.5 -2.2').");

            coordenadas = Console.ReadLine().Split(' ');

            x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            Console.WriteLine("");

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem.");
            }

            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y.");
            }

                else if (y == 0.0)
                {
                    Console.WriteLine("Eixo X.");
                }

                    else if (x > 0.0 && y > 0.0)
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
        }
    }
}
