using System;

namespace Prog08_Operacoes_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lembrando... TimeSpan = duração
            
            // MaxValue = pega a duração máxima possível de ser armazenada no TimeSpan
            TimeSpan duracaoTempo = TimeSpan.MaxValue;
            Console.WriteLine("Valor máximo de um TimeSpan = " + duracaoTempo);

            // MinValue = pega a duração mínima...
            TimeSpan duracaoTempo02 = TimeSpan.MinValue;
            Console.WriteLine("Valor mínimo de um TimeSpan = " + duracaoTempo02);

            // Zerando o TimeSpan...
            TimeSpan duracaoTempo03 = TimeSpan.Zero;
            Console.WriteLine("Valor zerado de um TimeSpan = " + duracaoTempo03);


            Console.WriteLine("\n\n2º PARTE DA AULA: CONTAGEM DE TEMPOS");

                                          //dias + horas + minutoa + segundos + milisegundos
            TimeSpan exemplo = new TimeSpan(18, 16, 29, 52, 12);
            
            Console.WriteLine("\nTimeSpan = " + exemplo);
            Console.WriteLine("\nTimeSpan.Days (conta os dias do TimeSpan) = " + exemplo.Days);
            Console.WriteLine("\nTimeSpan.Hours = " + exemplo.Hours);
            Console.WriteLine("\nTimeSpan.Minutes = " + exemplo.Minutes);
            Console.WriteLine("\nTimeSpan.Seconds = " + exemplo.Seconds);
            Console.WriteLine("\nTimeSpan.Milliseconds = " + exemplo.Milliseconds);
            Console.WriteLine("\nTimeSpan.Ticks = " + exemplo.Ticks);

            // Propriedades "Total"... Retornam os números 'quebrados', isto é, fracionados

            Console.WriteLine("\n\nTimeSpan.TotalDays = " + exemplo.TotalDays);
            Console.WriteLine("\nTimeSpan.TotalHours = " + exemplo.TotalHours);
            Console.WriteLine("\nTimeSpan.TotalMinutes = " + exemplo.TotalMinutes);
            Console.WriteLine("\nTimeSpan.TotalSeconds = " + exemplo.TotalSeconds);
            Console.WriteLine("\nTimeSpan.TotalMilliseconds = " + exemplo.TotalMilliseconds);


            Console.WriteLine("\n\n3º PARTE DA AULA: OPERAÇÕES");

                                            //horas + minutos + segundos
            TimeSpan exemplo02 = new TimeSpan(5, 30, 20);
            Console.WriteLine("\n\nTimeSpan 1 = " + exemplo02);

            TimeSpan exemplo03 = new TimeSpan(0, 10, 5);
            Console.WriteLine("\nTimeSpan 2 = " + exemplo03);

            TimeSpan soma = exemplo02.Add(exemplo03);
            Console.WriteLine("\n\nSoma dos TimeSpan 1 e 2 = " + soma);

            TimeSpan diferenca = exemplo02.Subtract(exemplo03);
            Console.WriteLine("\n\nDiferença dos TimeSpan 1 e 2 = " + diferenca);

            TimeSpan multiplicacao = exemplo03.Multiply(2.0);
            Console.WriteLine("\n\nMultiplicação do Time Span 2 (" + exemplo03 + ") por 2 = " + multiplicacao);

            TimeSpan divisao = exemplo02.Divide(2.0);
            Console.WriteLine("\n\nDivisão do Time Span 1 (" + exemplo02 + ") por 2 = " + divisao);

            Console.WriteLine();
        }
    }
}
