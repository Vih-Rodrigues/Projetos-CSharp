using System;

namespace Prog01_Struct
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Nesse caso, p não precisa receber um new Point pois a struct é do tipo valor
            Point P; // A simples declaração do P tipo Point já cria as caixas X e Y no stack da memória, podendo utilizá-las normalmente

            P.X = 10;
            P.Y = 20;

            Console.WriteLine(P);

            // Entretanto, o comando tipo struct aceita o comando new

            P = new Point();

            Console.WriteLine(P);

            // CONCLUSÃO: mesmo sendo tipo struct é preciso inicializar as caixas da struct
        }
    }
}
