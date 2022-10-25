using System;
using System.Collections.Generic;
using System.Text;
using Trabalho_RSA.Classes;

namespace Trabalho_RSA.Classes
{
    class Criptografar
    {
        // Método
        public static string CriptografarTexto(int e, int n, string textoParametro)
        {
            string textoCriptografado = "";
            int[] vetorInteiros = new int[textoParametro.Length];
            int[] vetorInteirosCriptografado = new int[textoParametro.Length];

            vetorInteiros = ConverteStringToNumber.RetornaNumeros(textoParametro);

            // Cálculo
            for (int i = 0; i < textoParametro.Length; i++)
            {
                //vetorInteirosCriptografado[i] = (Convert.ToInt32(Math.Pow(vetorInteiros[i], e)) % n);
                vetorInteirosCriptografado[i] = Convert.ToInt32(Math.Round((Math.Pow(vetorInteiros[i], e)) % n));
            }

            // Chama converte number to string
            textoCriptografado = ConverteNumberToString.RetornaTexto(vetorInteirosCriptografado);

            return textoCriptografado;
        }

    }
}
