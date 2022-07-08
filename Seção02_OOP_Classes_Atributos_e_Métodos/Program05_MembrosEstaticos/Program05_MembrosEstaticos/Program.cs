/*
    Udemy - curso C#
Seção 04 - material PDF
Página 20

Problema exemplo: Fazer um programa para ler um valor numérico qualquer, e daí mostrar
quanto seria o valor de uma circunferência e do volume de uma esfera
para um raio daquele valor. Informar também o valor de PI com duas
casas decimais.

Versão 1: métodos na própria classe do programa
• Nota: dentro de um método estático você não pode chamar membros de 
instância da mesma classe.
*/

using System;
using System.Globalization;

namespace Program05_MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            double raio_main, circunferencia_main, volume_main;

            Console.Write("Entre o valor do raio: ");
            raio_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            circunferencia_main = Circunferencia(raio_main);

            Console.WriteLine("\nCircunferência: " + circunferencia_main.ToString("F2", CultureInfo.InvariantCulture));

            volume_main = Volume(raio_main);

            Console.WriteLine("\nVolume: " + volume_main.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\nValor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}
