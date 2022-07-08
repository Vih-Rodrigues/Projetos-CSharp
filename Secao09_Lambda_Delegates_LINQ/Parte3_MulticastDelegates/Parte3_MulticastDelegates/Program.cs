using System;
using Parte3_MulticastDelegates.Servicos;
namespace Parte3_MulticastDelegates
{
    // Declaração do DELEGATE
    delegate void OperacaoNumericaBinaria(double n1, double n2);
    
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // Declaração do DELEGATE 
            OperacaoNumericaBinaria operacao;
            
            // DELEGATE "operacao" recebe referencia para a função "ApresentaSoma" da classe "ServicoCalculo"  
            operacao = ServicoCalculo.ApresentaSoma;

            // ACRESCENTA AO DELEGATE "operacao" a referencia para a função "ApresentaMaximo" da classe "ServicoCalculo" 
            operacao += ServicoCalculo.ApresentaMaximo;
            
            operacao.Invoke(a, b);
            // Sintaxe alternativa: operacao(a, b);
        }
    }
}