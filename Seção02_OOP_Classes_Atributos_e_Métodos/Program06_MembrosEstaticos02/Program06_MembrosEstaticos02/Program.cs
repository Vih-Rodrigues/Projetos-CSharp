/*
    Udemy - curso C#
Seção 04 - material PDF
Página 20

Problema exemplo: Fazer um programa para ler um valor numérico qualquer, e daí mostrar
quanto seria o valor de uma circunferência e do volume de uma esfera
para um raio daquele valor. Informar também o valor de PI com duas
casas decimais.

• Versão 2: classe Calculadora com membros de instância
*/

using System;
using System.Globalization;

namespace Program06_MembrosEstaticos02
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora_main;
 
            calculadora_main = new Calculadora();

            double raio_main, circunferencia_main, volume_main;

            Console.Write("Entre o valor do raio: ");
            raio_main = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            circunferencia_main = calculadora_main.Circunferencia(raio_main);
            volume_main = calculadora_main.Volume(raio_main);

            Console.WriteLine("\nCircunferência: " + circunferencia_main.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\nVolume: " + volume_main.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\nValor de Pi: " + calculadora_main.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}