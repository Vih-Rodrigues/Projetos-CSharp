using System;

namespace Prog01_PalavraVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração e instanciação de variável de modo COMUM
            int x = 10;

            // Utilizando a palavra VAR
            var y = 20; // Nesse caso, o uso de 'var' informa que a palavra seguinte, 'y', é uma variável, e o tipo dela será de acordo com sua inicialização (20 = inteiro).

            var z = 30.0; // "Z é uma variável, inicializada com um dado do tipo Double, portanto 'z' é uma variável do tipo double.

            var nome = "Vitoria"; // nome é uma variável instanciada com um dado do tipo string, portanto, 'nome' é uma variável do tipo string.

            Console.WriteLine(x + "\n" + y + "\n" + z + "\n" + nome);
        
            // DESVANTAGEM

            // O uso da palavra 'var' é uma comodidade, que recomenda-se utilizá-la em programas pequenos e simples
            // Há problemas no caso de atribuir o valor de uma variavel var em outra, por exemplo:
            // var exemplo = nome; => nesse caso, a IDE (Ambiente de Desenvolvimento Integrado, o Visual Studio), não apontará o erro, e o programador poderá se perder no código e perder muito tempo
        }
    }
}
