using System;

namespace Prog02_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string dia;

            Console.Write("Informe um número inteiro representando o dia da semana: ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    dia = "\nDomingo!";
                    break;

                case 2:
                    dia = "\nSegunda-feira!";
                    break;

                case 3:
                    dia = "\nTerça-feira!";
                    break;

                case 4:
                    dia = "\nQuarta-feira!";
                    break;

                case 5:
                    dia = "\nQuinta-feira!";
                    break;

                case 6:
                    dia = "\nSexta-feira!";
                    break;

                case 7:
                    dia = "\nSábado!";
                    break;

                default:
                    dia = "Dia inválido!";
                    break;
            }

            Console.WriteLine("\n" + dia);
        }
    }
}
