/* Estruturas Sequenciais
Exercício 06: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
Em seguida, calcule e mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B.
*/

using System;
using System.Globalization;

namespace Ex06_EstruturaSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            string[] vetor;

            Console.WriteLine("Exercício 06 - PONTO FLUTUANTE");
            Console.WriteLine("Informe os valores de A, B e C:");
            vetor = Console.ReadLine().Split(' ');

            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            areaTriangulo = (A * C) / 2;
            areaCirculo = 3.14159 * Math.Pow(C, 2.0);
            areaTrapezio = ((A + B) * C) / 2;
            areaQuadrado = Math.Pow(B, 2.0);
            areaRetangulo = A * B;

            Console.WriteLine("");
            Console.WriteLine("RESULTADOS:");
            Console.WriteLine("a) a área do triângulo retângulo que tem A por base e C por altura eh igual a " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("b) a área do círculo de raio C eh igual a " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("c) a área do trapézio que tem A e B por bases e C por altura eh igual a " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("d) a área do quadrado que tem lado B eh igual a " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("e) a área do retângulo que tem lados A e B eh igual a " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
