using System;
using Parte2_Delegate.Servicos;

namespace Parte2_Delegate
{
    // Declaração do DELEGATE:
    delegate double OperacaoNumericaBinaria(double valorParametro1, double valorParametro2);
    
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10, b = 12;

            // Declaração e instanciação da variável do tipo Delegate
            OperacaoNumericaBinaria operacao = ServicoCalculo.Soma;
            // Sintaxe alternativa: OperacaoNumericaBinaria operacao = new OperacaoNumericaBinaria(ServicoCalculo.Soma);

            double resultado;

            resultado = operacao(a, b);
            // Sintaxe alternativa: resultado= operacao.Invoke(a, b);
            // O Invoke invoca a função definida na instanciação da variável do tipo Delegate

            Console.WriteLine(resultado);
        }
    }
}
