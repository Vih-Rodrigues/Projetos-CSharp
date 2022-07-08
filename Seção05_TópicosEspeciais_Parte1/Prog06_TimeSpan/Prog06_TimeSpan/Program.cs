using System;

namespace Prog06_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // O TimeSpan pertence a biblioteca System!
            

            // 1º exemplo: construtor de três argumentos (hora, minuto e segundo)
            TimeSpan timeSpan01 = new TimeSpan(0, 1, 30);
            Console.WriteLine("TimeSpan de 3 argumentos = " + timeSpan01);

            // 2º exemplo: variável do tipo TimeSpan.Ticks
            Console.WriteLine("\nTicks do TimeSpan de 3 argumentos = " + timeSpan01.Ticks);


            // CONSTRUTORES DO TIMESPAN


            // 1º - TimeSpan vazio
            TimeSpan timeSpan02 = new TimeSpan();
            Console.WriteLine("\nTimeSpan vazio = " + timeSpan02);

            // 2º - passando uma quantidade de Ticks
            TimeSpan timeSpan03 = new TimeSpan(900000000L); // 900 milhões = 1 minuto e meio, "L" informa que trata-se de uma variável do tipo Long
            Console.WriteLine("\nTimeSpan de Ticks = " + timeSpan03);

            // 3º - três argumentos (hora, minuto e segundo)
            TimeSpan timeSpan04 = new TimeSpan(2, 11, 21);
            Console.WriteLine("\n2º TimeSpan de 3 argumentos = " + timeSpan04);

            // 4º - quatro argumentos (dias, horas, minutos e segundos)
            TimeSpan timeSpan05 = new TimeSpan(1, 5, 20, 46);
            Console.WriteLine("\nTimeSpan de 4 argumentos = " + timeSpan05);

            // 5º - cinco argumentos (dias, horas, minutos, segundos e milisegundos)
            TimeSpan timeSpan06 = new TimeSpan(1, 8, 13, 28, 321);
            Console.WriteLine("\nTimeSpan de 5 argumentos = " + timeSpan06);


            // 2º PARTE DA AULA: MÉTODOS FROM


            // 1° exemplo - criando um TimeSpan referente/equivalente a 1 dia e meio
            TimeSpan timeSpanFrom01 = TimeSpan.FromDays(1.5);
            Console.WriteLine("\nTimeSpanFrom 1 dia e meio = " + timeSpanFrom01);

            // 2° exemplo - criando um TimeSpan referente/equivalente 4 horas e meia
            TimeSpan timeSpanFrom02 = TimeSpan.FromHours(4.5);
            Console.WriteLine("\nTimeSpanFrom 4 horas e meia = " + timeSpanFrom02);

            // 3° exemplo - criando um TimeSpan referente/equivalente a 45 minutos e meio
            TimeSpan timeSpanFrom03 = TimeSpan.FromMinutes(45.5);
            Console.WriteLine("\nTimeSpanFrom 45 minutos e meio = " + timeSpanFrom03);

            // 4° exemplo - criando um TimeSpan referente/equivalente a 58 segundos e meio
            TimeSpan timeSpanFrom04 = TimeSpan.FromSeconds(58.5);
            Console.WriteLine("\nTimeSpanFrom 58 segundos e meio = " + timeSpanFrom04);

            // 5° exemplo - criando um TimeSpan referente/equivalente a 1 milisegundo e meio
            TimeSpan timeSpanFrom05 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine("\nTimeSpanFrom 1 milisegundo e meio = " + timeSpanFrom05);

            // 6° exemplo - criando um TimeSpan referente/equivalente a 900 milhões
            TimeSpan timeSpanFrom06 = TimeSpan.FromTicks(900000000L); // Ticks apenas aceita o valor Long pois é a menor unidade e, portanto, não pode ser quebrada
            Console.WriteLine("\nTimeSpanFrom 900 milhões de Ticks = " + timeSpanFrom06);
        }
    }
}
