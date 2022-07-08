using System;

namespace Programa06_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2; // Resultado = 11
            int n2 = (3 + 4) * 2; // Resultado = 14
            int n3 = 17 % 3;
            int n4 = 10 / 8; // resultado = 1
            double n5 = 10 / 8; // resultado = 1
            double n6 = (double)10 / 8; // USO DE CASTING -> resultado = 1.25
            double n7 = 10.0 / 8; // // resultado = 1.25

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);

            // Segunda parte da aula

            double a = 1.0, b = -3.0, c = -4.0;
                                      //2.0 = ao quadrado
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Função Math.Pow -> utilizada para calcular potenciação

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // Função Math.Sqrt -> raiz quadrada
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("");
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}