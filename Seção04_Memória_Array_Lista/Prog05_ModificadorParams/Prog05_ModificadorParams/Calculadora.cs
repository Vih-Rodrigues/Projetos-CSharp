namespace Prog05_ModificadorParams
{
    internal class Calculadora
    {
        // Função/Método Soma recebe vetor de numeros 
        public static int Soma(int[] numeros)
        {
            int soma = 0;
                                        // A função Length faz a leitura do tamanho do vetor
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

        // SEGUNDA PARTE DA AULA:

        // Função/Método SomaParams recebe vetor de numeros 
                                    // o params avisa à função que é desejado receber uma quantia VARIÁVEL de dados
        public static int SomaParams(params int[] numeros)
        {
            int soma = 0;
            // A função Length faz a leitura do tamanho do vetor
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }
    }
}
