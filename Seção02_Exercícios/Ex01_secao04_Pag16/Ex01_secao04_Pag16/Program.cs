/*
    Udemy - curso C#

Seção 04 - Arquivo PDF
Página 16

Exercício 01: Fazer um programa para ler os valores da largura e altura 
de um retângulo. Em seguida, mostrar na tela o valor de 
sua área, perímetro e diagonal. Usar uma classe como 
mostrado no projeto ao lado.
*/

using System;
using System.Globalization;

namespace Ex01_secao04_Pag16
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo_main;

            retangulo_main = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo:");
            retangulo_main.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo_main.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nAREA = " + retangulo_main.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + retangulo_main.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo_main.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
