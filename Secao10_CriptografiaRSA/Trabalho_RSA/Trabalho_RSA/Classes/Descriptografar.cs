using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_RSA.Classes
{
    class Descriptografar
    {
        // chama ConverteNumberToString

        // Método
        public static string DescriptografarTexto(int d, int n, string textoParametro, bool textoJaCriptoParametro)
        {
            string textoDescriptografado = "";
            int[] vetorInteirosCriptografado = new int[textoParametro.Length];
            int[] vetorInteirosDescriptografado = new int[textoParametro.Length];

            // Se o texto já foi criptografado, ele pega o vetor numérico da classe ArmazenaCriptografia
            if (textoJaCriptoParametro == true)
            {
                // Recupera o vetor guardado no método Armazena
                
                vetorInteirosCriptografado = Program.auxiliar_;

                // Cálculo
                for (int i = 0; i < textoParametro.Length; i++)
                {                    
                    vetorInteirosDescriptografado[i] = Convert.ToInt32(Math.Round((Math.Pow(vetorInteirosCriptografado[i], d)) % n));
                }

                // Chama converte number to string
                textoDescriptografado = ConverteNumberToString.RetornaTexto(vetorInteirosDescriptografado);
            }

            // Caso contrário, considera uma nova criptografia para descriptografar
            else
            {
                vetorInteirosCriptografado = ConverteStringToNumber.RetornaNumeros(textoParametro);

                // Cálculo
                for (int i = 0; i < textoParametro.Length; i++)
                {
                    vetorInteirosDescriptografado[i] = (Convert.ToInt32(Math.Round((Math.Pow(vetorInteirosCriptografado[i], d)) % n)));
                }

                // Chama converte number to string
                textoDescriptografado = ConverteNumberToString.RetornaTexto(vetorInteirosDescriptografado);   
            }

            return textoDescriptografado;
        }
    }
}
