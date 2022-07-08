/*
Udemy - curso C#
Aula 32
Problema exemplo: Digitar um número e mostrar sua raiz quadrada com três casas decimais, depois repetir o procedimento.
Quando o usuário digitar um número negativo (podendo inclusive ser na primeira vez), mostrar uma mensagem "Número negativo"
e terminar o programa.
 */

using System;
using System.Globalization;

namespace Programa14_While
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0, raiz = 0;

            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numero >= 0.0)
            {
                raiz = Math.Sqrt(numero);
                
                Console.WriteLine("\n " + raiz.ToString("F4", CultureInfo.InvariantCulture));

                Console.Write("\nDigite um número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("\nNúmero negativo!\n");
        }
    }
}