using System;

namespace Prog02_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // double w = null; -> não é possível pois a variável 'w' é um dado do tipo valor

            // Resolvendo: 1º FORMA DE ESCREVER NULLABLE

            Nullable<double> w;
            w = null;

            // Resolvendo: 2º FORMA DE ESCREVER NULLABLE
            
            double? x;
            x = null;

            // 2º PARTE DA AULA 

            double? y = 10.0;
                                // GetValueOrDefault = pega o valor de y OU se o valor não existir, pega o valor PADRÃO do tipo da variável y
            Console.WriteLine(x.GetValueOrDefault()); // 0
            Console.WriteLine(y.GetValueOrDefault()); // 10

                                // HasValue = diz se dentro da propriedade y existe valor
            Console.WriteLine(x.HasValue); // False
            Console.WriteLine(y.HasValue); // True

                                // Value = pega o valor diretamento do y
            //Console.WriteLine(x.Value); // Aplicação quebra pois o y é nulo
            //Console.WriteLine(y.Value);

            // Nesse caso, podemos fazer...

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }

            else
            {
                Console.WriteLine("x is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }

            else
            {
                Console.WriteLine("y is null");
            }

            // 3º PARTE DA AULA - DEMO

            double? a = null;
            double? b = 10;

            double c = a ?? 5; // Variável 'c' receberá o valor de 'a', mas se o valor de 'a' for nulo, 'c' receberá o valor 5 
            double d = y ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
