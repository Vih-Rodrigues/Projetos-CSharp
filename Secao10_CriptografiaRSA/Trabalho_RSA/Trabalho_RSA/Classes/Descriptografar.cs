using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_RSA.Classes
{
    class Descriptografar
    {
        // chama ConverteNumberToString

        // Método
        public static string DescriptografarTexto(int d, int n, string textoParametro)
        {
            string textoDescriptografado = "";
            int[] vetorInteirosCriptografado = new int[textoParametro.Length];
            int[] vetorInteirosDescriptografado = new int[textoParametro.Length];

            vetorInteirosDescriptografado = ConverteStringToNumber.RetornaNumeros(textoParametro);

            // Cálculo
            for (int i = 0; i <= textoParametro.Length; i++)
            {
                vetorInteirosDescriptografado[i] = (Convert.ToInt32(Math.Pow(vetorInteirosCriptografado[i], d)) % n);
            }

            // Chama converte number to string
            textoDescriptografado = ConverteNumberToString.RetornaTexto(vetorInteirosDescriptografado);

            return textoDescriptografado;
        }
    }
}
