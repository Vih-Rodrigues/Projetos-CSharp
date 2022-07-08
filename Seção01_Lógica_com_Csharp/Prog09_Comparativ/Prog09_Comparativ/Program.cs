using System;

namespace Prog09_Comparativ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores comparativos com variáveis booleanas
            int a = 10;

            bool elemento01 = a < 10;
            bool elemento02 = a < 20;
            bool elemento03 = a > 10;
            bool elemento04 = a > 5;

            Console.WriteLine(elemento01);
            Console.WriteLine(elemento02);
            Console.WriteLine(elemento03);
            Console.WriteLine(elemento04);
            Console.WriteLine("");
            Console.WriteLine("---------");

            // Segunda parte da aula 
            bool elemento05 = a <= 10;
            bool elemento06 = a >= 10;
            bool elemento07 = a == 10;
            bool elemento08 = a != 10;

            Console.WriteLine("");
            Console.WriteLine(elemento05);
            Console.WriteLine(elemento06);
            Console.WriteLine(elemento07);
            Console.WriteLine(elemento08);
        }
    }
}