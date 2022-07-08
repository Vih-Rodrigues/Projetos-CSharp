using System;

namespace Prog07_Operacoes_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 12, 21, 08, 33, 58, 275);
            Console.WriteLine("DateTime = " + dt);

            // Informando somente a data, ignorando as horas...
            Console.WriteLine("\nDateTime -> Date = " + dt.Date);

            // Informando somente o dia...
            Console.WriteLine("\nDateTime -> Day = " + dt.Day);

            Console.WriteLine("\nDateTime -> DayOfWeek: " + dt.DayOfWeek);
            Console.WriteLine("\nDateTime -> DayOfYear: " + dt.DayOfYear);
            Console.WriteLine("\nDateTime -> Hour: " + dt.Hour);
            Console.WriteLine("\nDateTime -> Kind (tipo local ou universal): " + dt.Kind);
            Console.WriteLine("\nDateTime -> Millisecond: " + dt.Millisecond);
            Console.WriteLine("\nDateTime -> Minute: " + dt.Minute);
            Console.WriteLine("\nDateTime -> Month: " + dt.Month);
            Console.WriteLine("\nDateTime -> Second: " + dt.Second);
            Console.WriteLine("\nDateTime -> Ticks: " + dt.Ticks);
            Console.WriteLine("\nDateTime -> TimeOfDay: " + dt.TimeOfDay); // TimeSpan! Pois é uma DURAÇÃO
            Console.WriteLine("\nDateTime -> Year: " + dt.Year);


            Console.WriteLine("\n\n2º PARTE DA AULA: FORMATAÇÃO");


                                        // ano + mês + dia + hora + minuto + segundo + milisegundo
            DateTime dt02 = new DateTime(2021, 12, 22, 05, 38, 22, 842);
            Console.WriteLine("\n\nDateTime.ToLongDateString (formatação mais completa: dia da semana + data) = " + dt02.ToLongDateString());

            // É possível, também, armazenar esse dado em uma string:
            string exemplo = dt02.ToLongDateString();
            Console.WriteLine("\nString recebendo DateTime.ToLongDateString = " + exemplo);

            // 'ToLongTimeString' atribui o horário da variável DateTime à variável string
            string exemplo02 = dt02.ToLongTimeString();
            Console.WriteLine("\nString recebendo DateTime.ToLongTimeString (horário completo) = " + exemplo02);

            // ToShort...

            // 'ToShortDateString' atribui somente a data, de modo mais "curto", sem o dia da semana
            string exemplo03 = dt02.ToShortDateString();
            Console.WriteLine("\nString recebendo DateTime.ToShortDateString (apenas data) = " + exemplo03);

            // 'ToShortTimeString' atribui somente a hora e o minuto da variável DateTime à variável string
            string exemplo04 = dt02.ToShortTimeString();
            Console.WriteLine("\nString recebendo DateTime.ToShortTimeString (apenas hora e minuto) = " + exemplo04);

            // SOBRECARGAS DO 'ToString'
            
            // Exemplo: máscara de formatação
            string exemplo05 = dt02.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("\nString recebendo máscara de formatação do DateTime por ano-mês-dia + hora:minuto:segundo = " + exemplo05);

            // Exemplo: máscara de formatação incluindo os milisegundos
            string exemplo06 = dt02.ToString("yyyy-MM-dd HH:mm:ss:fff"); // "fff" informa que é desejado a inclusão dos milisegundos
            Console.WriteLine("\nString recebendo máscara de formatação do DateTime por ano-mês-dia + hora:minuto:segundo:milisegundo = " + exemplo06);


            Console.WriteLine("\n\n3º PARTE DA AULA: OPERAÇÕES");

            DateTime dt03 = new DateTime(2021, 12, 25, 16, 38, 30);
            Console.WriteLine("\n\nDateTime original = " + dt03);

            // 'AddHours(n)' adiciona n horas à variável DateTime
            DateTime dt04 = dt03.AddHours(2);
            Console.WriteLine("\nAddHours(2) = " + dt04);

            // 'AddMinutes(n)' adiciona n minutos à variável DateTime
            DateTime dt05 = dt03.AddMinutes(20);
            Console.WriteLine("\nAddMinutes(20) = " + dt05);


            // Situação exemplo: você comprou um produto agora, e tem até 7 dias para pagar o boleto
            // Temos a seguinte situação:
            Console.WriteLine("\n\nSituação exemplo: compra de um produto x pela internet.");
            
            DateTime sitExemplo = DateTime.Now;
            Console.WriteLine("\nCompra realizada em = " + sitExemplo);
            
            DateTime sitExemplo02 = sitExemplo.AddDays(7);
            Console.WriteLine("\nPrazo para realizar o pagamento do boleto = " + sitExemplo02);


            // Situação exemplo: deseja-se saber a diferença entre duas datas
            // Temos a seguinte situação:
            Console.WriteLine("\n\nSituação exemplo 02: deseja-se saber a diferença em dias entre o dia 31 de março de 2002 e o dia 24 de novembro de 1973.");

            DateTime sitExemplo03 = new DateTime(1973, 11, 24);
            DateTime sitExemplo04 = new DateTime(2002, 03, 31);

            // TimeSpan pois trata-se da duração entre as duas datas
            TimeSpan tempoDiferenca = sitExemplo04.Subtract(sitExemplo03);
            Console.WriteLine("\nDiferença em dias = " + tempoDiferenca);

            Console.WriteLine("");
        }
    }
}
