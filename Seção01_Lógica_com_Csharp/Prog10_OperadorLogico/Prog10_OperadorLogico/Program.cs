using System;

namespace Prog10_OperadorLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores lógicos com variáveis booleanas
            bool elemento01 = 4 != 5; // TRUE
            bool elemento02 = 2 > 3 && 4 != 5; // FALSE, pois 2 > 3 é falso
            bool elemento03 = 2 > 3 || 4 != 5; // TRUE, pois 4 != 5 é verdadeiro

            Console.WriteLine(elemento01);
            Console.WriteLine(elemento02);
            Console.WriteLine(elemento03);
            Console.WriteLine("");
            Console.WriteLine("---------");

            // Segunda parte da aula - PRECEDÊNCIA
                            // "2 NÃO é maior do que 3 E 4 é diferente de 5"
            bool elemento04 = !(2 > 3) && 4 != 5; // TRUE

            Console.WriteLine(elemento04);
            Console.WriteLine("");
            Console.WriteLine("---------");

            // Terceira parte da aula - PRECEDÊNCIA
            bool elemento05 = 10 < 5;

                           //  (TRUE)    OU    (TRUE    E    FALSE)
            bool elemento06 = elemento03 || elemento04 && elemento05; // TRUE

            Console.WriteLine(elemento05);
            Console.WriteLine("");
            Console.WriteLine(elemento06);
        }
    }
}