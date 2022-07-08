namespace Prog06_Modificadores_Ref_Out
{
    internal class Calculadora
    {
        // Método/função que NÃO altera o valor da variável 'a' que foi passada por parâmetro
        public static void Triplo(int x)
        {
            x = x * 3;
        }

        // SEGUNDA PARTE:
                                    // A função 'ref' faz o parâmetro 'y' se tornar uma referência para a variável original 'b', podendo altera-lá
        public static void Triplo02(ref int y)
        {
            y = y * 3;
        }

        // TERCEIRA PARTE DA AULA: MODIFICADOR DE PARÂMETRO OUT

        public static void Triplo03(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
