using System;

namespace Prog09_DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime01 = new DateTime(2021, 12, 21, 16, 13, 01);
            DateTime dateTime02 = new DateTime(2021, 12, 21, 16, 13, 01, DateTimeKind.Local);
            DateTime dateTime03 = new DateTime(2021, 12, 21, 16, 13, 01, DateTimeKind.Utc);

            Console.WriteLine("DateTime: " + dateTime01);
            Console.WriteLine("DateTime Local: " + dateTime02);
            Console.WriteLine("DateTime Utc: " + dateTime03);

            // Assim, nada foi alterado pois a máquina compreende que é desejado retornar do modo que foi instanciado
            // Portanto, para alterar os dados, temos:

            Console.WriteLine("\n\nDateTime Kind: " + dateTime01.Kind);
            Console.WriteLine("DateTime to Local: " + dateTime01.ToLocalTime());
            Console.WriteLine("DateTime to Utc: " + dateTime01.ToUniversalTime());

            Console.WriteLine("\n\nDateTime Local Kind: " + dateTime02.Kind);
            Console.WriteLine("DateTime Local to Local: " + dateTime02.ToLocalTime());
            Console.WriteLine("DateTime Local to Utc: " + dateTime02.ToUniversalTime());

            Console.WriteLine("\n\nDateTime Utc Kind: " + dateTime03.Kind);
            Console.WriteLine("DateTime Utc to Local: " + dateTime03.ToLocalTime());
            Console.WriteLine("DateTime Utc to Utc: " + dateTime03.ToUniversalTime());

            Console.WriteLine("\n\n2º PARTE DA AULA - PADRÃO ISO 8601");

            DateTime dt01 = DateTime.Parse("2021-12-21 16:30:01");
            Console.WriteLine("\n\nInstanciando o DateTime normalmente = " + dt01);

            DateTime dt02 = DateTime.Parse("2021-12-21T16:30:01Z");
            Console.WriteLine("Instanciando o DateTime no padrão ISO: " + dt02);

            Console.WriteLine("\n\ndt01: " + dt01.Kind);
            Console.WriteLine("dt01 to Local: " + dt01.ToLocalTime());
            Console.WriteLine("dt01 to Utc: " + dt01.ToUniversalTime());

            Console.WriteLine("\n\ndt02: " + dt02.Kind);
            Console.WriteLine("dt02 to Local: " + dt02.ToLocalTime());
            Console.WriteLine("dt02 to Utc: " + dt02.ToUniversalTime());

            // Curiosidade...
            // Passando como máscara de formatação o padrão ISO 8601
            
            // Jeito ERRADO!
            Console.WriteLine("\n\ndt02.ToString: " + dt02.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            
            // Jeito CERTO - 1º garantir que a variável DateTime esteja no formato 'ToUniversalTime'
            Console.WriteLine("\ndt02.ToUniversalTime().ToString('yyyy-MM-ddTHH:mm:ssZ'): " + dt02.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
