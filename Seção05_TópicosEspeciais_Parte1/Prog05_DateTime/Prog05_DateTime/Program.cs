using System;
using System.Globalization;

namespace Prog05_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime é uma função da biblioteca System!
            // Now é uma propriedade que retorna o instante atual do sistema.
            DateTime dateTimeMain = DateTime.Now; 
            Console.WriteLine("\nDateTime01: " + dateTimeMain);

            // Ticks: O número impresso é a quantidade de ticks que já passaram desde o dia 1 de janeiro a meia-noite da era atual, até o dia de hoje, neste horário.
            Console.WriteLine("\nDateTime01.Ticks: " + dateTimeMain.Ticks);


            // 2º PARTE DA AULA
            // Instanciando o DateTime com construtor:
            DateTime dateTime02 = new DateTime(2021, 12, 20);
            Console.WriteLine("\nDateTime02: " + dateTime02);

            // Para especificar as horas, é necessário incluir no construtor:
            DateTime dateTime03 = new DateTime(2021, 12, 20, 20, 45, 03);
            Console.WriteLine("\nDateTime03: " + dateTime03);


            // 3º PARTE DA AULA
            // Instanciando o DateTime com builders:
            
            DateTime dateTime04 = DateTime.Now;
            Console.WriteLine("\nDateTime04: " + dateTime04);

            DateTime dateTime05 = DateTime.Today;
            Console.WriteLine("\nDateTime05: " + dateTime05);

            DateTime dateTime06 = DateTime.UtcNow; // Utc = horário atual no Greenwich
            Console.WriteLine("\nDateTime06: " + dateTime06);


            // Builder: Parse

            DateTime dateTime07 = DateTime.Parse("2021-12-21");
            Console.WriteLine("\nDateTime07: " + dateTime07);

            DateTime dateTime08 = DateTime.Parse("2021-12-21 00:04:58");
            Console.WriteLine("\nDateTime08: " + dateTime08);

            DateTime dateTime09 = DateTime.Parse("20/12/2021");
            Console.WriteLine("\nDateTime09: " + dateTime09);

            DateTime dateTime10 = DateTime.Parse("20/12/2021 19:54:05");
            Console.WriteLine("\nDateTime10: " + dateTime10);


            // Builder: ParseExact

            DateTime dateTime11 = DateTime.ParseExact("2021-12-20", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine("\nDateTime11: " + dateTime11);

            DateTime dateTime12 = DateTime.ParseExact("20/12/2021 19:59:48", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("\nDateTime12: " + dateTime12);
        }
    }
}
