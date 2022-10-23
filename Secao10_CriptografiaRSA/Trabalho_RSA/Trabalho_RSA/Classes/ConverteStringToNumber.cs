/*
----- Tabela não ASCII -----
0               ' ' (espaço)
1234            !	
1235	        "	(aspas duplas)
1236	        #	
1237	        $	
1238	        %	
1239	        &	
1240	        '	apóstrofe (aspas simples)
1241	        (	
1242	        )	
1243	        *	
1244	        +	
1245	        ,
1246	        -
1247	        .
1248	        /	
4321	        0	
4320	        1	
4319	        2	
4318	        3	
4317	        4	
4316	        5	
4315	        6	
4314	        7	
4313	        8	
4312	        9	
201	            :	
202	            ;	
203	            <	
204	            =	
205	            >	
206	            ?	
207 	        @	
9876	        A	
9875	        B	
9874	        C	
9873	        D	
9872	        E	
9871	        F	
9870	        G	
9869	        H	
9868	        I	
9867	        J	
9866	        K	
9865	        L	
9864	        M	
9863	        N	
9862	        O	
9861	        P	
9860	        Q	
9859	        R	
9858	        S	
9857	        T	
9856	        U	
9855	        V	
9854	        W	
9853	        X	
9852	        Y	
9851	        Z	
101	            [	
102	            \	
103	            ]	
104	            ^	
105	            _	(underscore)
6789	        a	
6788	        b	
6787	        c	
6786	        d	
6785            e	
6784	        f	
6783	        g	
6782            h	
6781	        i	
6780	        j	
6779	        k	
6778	        l	
6777	        m	
6776	        n	
6775	        o	
6774	        p	
6773	        q	
6772	        r	
6771	        s	
6770	        t	
6769	        u	
6768	        v	
6767	        w	
6766	        x	
6765	        y	
6764	        z	
301	            {	
302	            |	
303	            }	
304	            ~
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_RSA.Classes
{
    class ConverteStringToNumber
    {
        // Método para conversão da frase em vetor numérico
        public static int[] RetornaNumeros(string textoParametro)
        {
            // Função ToCharArray separa cada caractere da string, colocando-o no vetor
            char[] vetorTexto = textoParametro.ToCharArray();

            // Vetor inteiro para guardar os números que serão passados para string
            int[] vetorInteiros = new int[textoParametro.Length];

            for (int i = 0; i <= textoParametro.Length; i++)
            {
                if (vetorTexto[i] == ' ')
                {
                    vetorInteiros[i] = 0;
                }

                else if (vetorTexto[i] == '!')
                {
                    vetorInteiros[i] = 1234;
                }

                else if (vetorTexto[i] == '\"') // aspas duplas
                {
                    vetorInteiros[i] = 1235;
                }

                else if (vetorTexto[i] == '#')
                {
                    vetorInteiros[i] = 1236;
                }

                else if (vetorTexto[i] == '$')
                {
                    vetorInteiros[i] = 1237;
                }

                else if (vetorTexto[i] == '%')
                {
                    vetorInteiros[i] = 1238;
                }

                else if (vetorTexto[i] == '&')
                {
                    vetorInteiros[i] = 1239;
                }

                else if (vetorTexto[i] == '\'') // aspas simples
                {
                    vetorInteiros[i] = 1240;
                }

                else if (vetorTexto[i] == '(')
                {
                    vetorInteiros[i] = 1241;
                }

                else if (vetorTexto[i] == ')')
                {
                    vetorInteiros[i] = 1242;
                }

                else if (vetorTexto[i] == '*')
                {
                    vetorInteiros[i] = 1243;
                }

                else if (vetorTexto[i] == '+')
                {
                    vetorInteiros[i] = 1244;
                }

                else if (vetorTexto[i] == ',')
                {
                    vetorInteiros[i] = 1245;
                }

                else if (vetorTexto[i] == '-')
                {
                    vetorInteiros[i] = 1246;
                }

                else if (vetorTexto[i] == '.')
                {
                    vetorInteiros[i] = 1247;
                }

                else if (vetorTexto[i] == '/')
                {
                    vetorInteiros[i] = 1248;
                }

                else if (vetorTexto[i] == '0')
                {
                    vetorInteiros[i] = 4321;
                }

                else if (vetorTexto[i] == '1')
                {
                    vetorInteiros[i] = 4320;
                }

                else if (vetorTexto[i] == '2')
                {
                    vetorInteiros[i] = 4319;
                }

                else if (vetorTexto[i] == '3')
                {
                    vetorInteiros[i] = 4318;
                }

                else if (vetorTexto[i] == '4')
                {
                    vetorInteiros[i] = 4317;
                }

                else if (vetorTexto[i] == '5')
                {
                    vetorInteiros[i] = 4316;
                }

                else if (vetorTexto[i] == '6')
                {
                    vetorInteiros[i] = 4315;
                }

                else if (vetorTexto[i] == '7')
                {
                    vetorInteiros[i] = 4314;
                }

                else if (vetorTexto[i] == '8')
                {
                    vetorInteiros[i] = 4313;
                }

                else if (vetorTexto[i] == '9')
                {
                    vetorInteiros[i] = 4312;
                }

                else if (vetorTexto[i] == ':')
                {
                    vetorInteiros[i] = 201;
                }

                else if (vetorTexto[i] == ';')
                {
                    vetorInteiros[i] = 202;
                }

                else if (vetorTexto[i] == '<')
                {
                    vetorInteiros[i] = 203;
                }

                else if (vetorTexto[i] == '=')
                {
                    vetorInteiros[i] = 204;
                }

                else if (vetorTexto[i] == '>')
                {
                    vetorInteiros[i] = 205;
                }

                else if (vetorTexto[i] == '?')
                {
                    vetorInteiros[i] = 206;
                }

                else if (vetorTexto[i] == '@')
                {
                    vetorInteiros[i] = 207;
                }

                else if (vetorTexto[i] == 'A')
                {
                    vetorInteiros[i] = 9876;
                }

                else if (vetorTexto[i] == 'B')
                {
                    vetorInteiros[i] = 9875;
                }

                else if (vetorTexto[i] == 'C')
                {
                    vetorInteiros[i] = 9874;
                }

                else if (vetorTexto[i] == 'D')
                {
                    vetorInteiros[i] = 9873;
                }

                else if (vetorTexto[i] == 'E')
                {
                    vetorInteiros[i] = 9872;
                }

                else if (vetorTexto[i] == 'F')
                {
                    vetorInteiros[i] = 9871;
                }

                else if (vetorTexto[i] == 'G')
                {
                    vetorInteiros[i] = 9870;
                }

                else if (vetorTexto[i] == 'H')
                {
                    vetorInteiros[i] = 9869;
                }

                else if (vetorTexto[i] == 'I')
                {
                    vetorInteiros[i] = 9868;
                }

                else if (vetorTexto[i] == 'J')
                {
                    vetorInteiros[i] = 9867;
                }

                else if (vetorTexto[i] == 'K')
                {
                    vetorInteiros[i] = 9866;
                }

                else if (vetorTexto[i] == 'L')
                {
                    vetorInteiros[i] = 9865;
                }

                else if (vetorTexto[i] == 'M')
                {
                    vetorInteiros[i] = 9864;
                }

                else if (vetorTexto[i] == 'N')
                {
                    vetorInteiros[i] = 9863;
                }

                else if (vetorTexto[i] == 'O')
                {
                    vetorInteiros[i] = 9862;
                }

                else if (vetorTexto[i] == 'P')
                {
                    vetorInteiros[i] = 9861;
                }

                else if (vetorTexto[i] == 'Q')
                {
                    vetorInteiros[i] = 9860;
                }

                else if (vetorTexto[i] == 'R')
                {
                    vetorInteiros[i] = 9859;
                }

                else if (vetorTexto[i] == 'S')
                {
                    vetorInteiros[i] = 9858;
                }

                else if (vetorTexto[i] == 'T')
                {
                    vetorInteiros[i] = 9857;
                }

                else if (vetorTexto[i] == 'U')
                {
                    vetorInteiros[i] = 9856;
                }

                else if (vetorTexto[i] == 'V')
                {
                    vetorInteiros[i] = 9855;
                }

                else if (vetorTexto[i] == 'W')
                {
                    vetorInteiros[i] = 9854;
                }

                else if (vetorTexto[i] == 'X')
                {
                    vetorInteiros[i] = 9853;
                }

                else if (vetorTexto[i] == 'Y')
                {
                    vetorInteiros[i] = 9852;
                }

                else if (vetorTexto[i] == 'Z')
                {
                    vetorInteiros[i] = 9851;
                }

                else if (vetorTexto[i] == '[')
                {
                    vetorInteiros[i] = 101;
                }

                else if (vetorTexto[i] == '\')
                {
                    vetorInteiros[i] = 102;
                }

                else if (vetorTexto[i] == ']')
                {
                    vetorInteiros[i] = 103;
                }

                else if (vetorTexto[i] == '^')
                {
                    vetorInteiros[i] = 104;
                }

                else if (vetorTexto[i] == '_')
                {
                    vetorInteiros[i] = 105;
                }

                else if (vetorTexto[i] == 'a')
                {
                    vetorInteiros[i] = 6789;
                }

                else if (vetorTexto[i] == 'b')
                {
                    vetorInteiros[i] = 6788;
                }

                else if (vetorTexto[i] == 'c')
                {
                    vetorInteiros[i] = 6787;
                }

                else if (vetorTexto[i] == 'd')
                {
                    vetorInteiros[i] = 6786;
                }

                else if (vetorTexto[i] == 'e')
                {
                    vetorInteiros[i] = 6785;
                }

                else if (vetorTexto[i] == 'f')
                {
                    vetorInteiros[i] = 6784;
                }

                else if (vetorTexto[i] == 'g')
                {
                    vetorInteiros[i] = 6783;
                }

                else if (vetorTexto[i] == 'h')
                {
                    vetorInteiros[i] = 6782;
                }

                else if (vetorTexto[i] == 'i')
                {
                    vetorInteiros[i] = 6781;
                }

                else if (vetorTexto[i] == 'j')
                {
                    vetorInteiros[i] = 6780;
                }

                else if (vetorTexto[i] == 'k')
                {
                    vetorInteiros[i] = 6779;
                }

                else if (vetorTexto[i] == 'l')
                {
                    vetorInteiros[i] = 6778;
                }

                else if (vetorTexto[i] == 'm')
                {
                    vetorInteiros[i] = 6777;
                }

                else if (vetorTexto[i] == 'n')
                {
                    vetorInteiros[i] = 6776;
                }

                else if (vetorTexto[i] == 'o')
                {
                    vetorInteiros[i] = 6775;
                }

                else if (vetorTexto[i] == 'p')
                {
                    vetorInteiros[i] = 6774;
                }

                else if (vetorTexto[i] == 'q')
                {
                    vetorInteiros[i] = 6773;
                }

                else if (vetorTexto[i] == 'r')
                {
                    vetorInteiros[i] = 6772;
                }

                else if (vetorTexto[i] == 's')
                {
                    vetorInteiros[i] = 6771;
                }

                else if (vetorTexto[i] == 't')
                {
                    vetorInteiros[i] = 6770;
                }

                else if (vetorTexto[i] == 'u')
                {
                    vetorInteiros[i] = 6769;
                }

                else if (vetorTexto[i] == 'v')
                {
                    vetorInteiros[i] = 6768;
                }

                else if (vetorTexto[i] == 'w')
                {
                    vetorInteiros[i] = 6767;
                }

                else if (vetorTexto[i] == 'x')
                {
                    vetorInteiros[i] = 6766;
                }

                else if (vetorTexto[i] == 'y')
                {
                    vetorInteiros[i] = 6765;
                }

                else if (vetorTexto[i] == 'z')
                {
                    vetorInteiros[i] = 6764;
                }

                else if (vetorTexto[i] == '{')
                {
                    vetorInteiros[i] = 301;
                }

                else if (vetorTexto[i] == '|')
                {
                    vetorInteiros[i] = 302;
                }

                else if (vetorTexto[i] == '}')
                {
                    vetorInteiros[i] = 303;
                }

                else if (vetorTexto[i] == '~')
                {
                    vetorInteiros[i] = 304;
                }
            }
            
            return vetorInteiros[];
        }
    }
}
