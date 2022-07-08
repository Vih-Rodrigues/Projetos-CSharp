/*
Udemy - Curso C#
Estruturas condicionais
Exercício 04: Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
*/

using System;

namespace Ex04_EstruturaCo
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora01, hora02, horaTotal;
            string[] horasJogando;

            Console.WriteLine("Informe a hora de inicio e a hora de término do período em que ficou jogando:");
            horasJogando = Console.ReadLine().Split(' ');

            hora01 = int.Parse(horasJogando[0]);
            hora02 = int.Parse(horasJogando[1]);

            if (hora01 < hora02)
            {
                horaTotal = hora02 - hora01;
            }

            else
            {
                horaTotal = 24 - hora01 + hora02;
            }

            Console.WriteLine("O JOGO DUROU " + horaTotal + " hora(s).");
        }
    }
}