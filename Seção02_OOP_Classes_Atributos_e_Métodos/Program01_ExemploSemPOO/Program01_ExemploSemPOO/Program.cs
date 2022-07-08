/*      
      Udemy - curso C#
        Seção 04

Problema-Exemplo: Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). 
Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a fórmula de Heron.
*/

using System;
using System.Globalization;

namespace Program01_ExemploSemPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado01_X, lado02_X, lado03_X, lado01_Y, lado02_Y, lado03_Y, PX, PY, areaX, areaY;
            string[] trianguloX, trianguloY;

            Console.WriteLine("MEDIDAS -EXEMPLO: '2.5 - 6 - 1.8\n'");
            Console.WriteLine("Informe as medidas do triângulo X:");
            trianguloX = Console.ReadLine().Split(" - ");

            lado01_X = double.Parse(trianguloX[0], CultureInfo.InvariantCulture);
            lado02_X = double.Parse(trianguloX[1], CultureInfo.InvariantCulture);
            lado03_X = double.Parse(trianguloX[2], CultureInfo.InvariantCulture);   

            Console.WriteLine("\nInforme as medidas do triângulo Y:");
            trianguloY = Console.ReadLine().Split(" - ");

            lado01_Y = double.Parse(trianguloY[0], CultureInfo.InvariantCulture);
            lado02_Y = double.Parse(trianguloY[1], CultureInfo.InvariantCulture);
            lado03_Y = double.Parse(trianguloY[2], CultureInfo.InvariantCulture);

            // Encontrando o P
            PX = (lado01_X + lado02_X + lado03_X) / 2.0;

            areaX = Math.Sqrt(PX * (PX - lado01_X) * (PX - lado02_X) * (PX - lado03_X));

            PY = (lado01_Y + lado02_Y + lado03_Y) / 2.0;

            areaY = Math.Sqrt(PY * (PY - lado01_Y) * (PY - lado02_Y) * (PY - lado03_Y));

            Console.WriteLine("\nÁrea de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("\nMaior área: X");
            }

            else
            {
                Console.WriteLine("\nMaior área: Y");
            }
        }
    }
}

