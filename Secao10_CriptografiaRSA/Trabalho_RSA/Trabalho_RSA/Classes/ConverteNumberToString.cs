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
    class ConverteNumberToString
    {
        // Método para conversão da frase em vetor numérico
        public static string RetornaTexto(int[] vetorNumericoParametro)
        {
            char[] vetorCaracteres = new char[vetorNumericoParametro.Length];
            string textoResultado = "";

            for (int i = 0; i < vetorNumericoParametro.Length; i++)
            {
                if (vetorNumericoParametro[i] == 0)
                {
                    vetorCaracteres[i] = ' ';
                }

                else if (vetorNumericoParametro[i] == 1234)
                {
                    vetorCaracteres[i] = '!';
                }

                else if (vetorNumericoParametro[i] == 1235)
                {
                    vetorCaracteres[i] = '\"'; // aspas duplas
                }

                else if (vetorNumericoParametro[i] == 1236)
                {
                    vetorCaracteres[i] = '#';
                }

                else if (vetorNumericoParametro[i] == 1237)
                {
                    vetorCaracteres[i] = '$';
                }

                else if (vetorNumericoParametro[i] == 1238)
                {
                    vetorCaracteres[i] = '%';
                }

                else if (vetorNumericoParametro[i] == 1239)
                {
                    vetorCaracteres[i] = '&';
                }

                else if (vetorNumericoParametro[i] == 1240) // aspas simples
                {
                    vetorCaracteres[i] = '\'';
                }

                else if (vetorNumericoParametro[i] == 1241)
                {
                    vetorCaracteres[i] = '(';
                }

                else if (vetorNumericoParametro[i] == 1242)
                {
                    vetorCaracteres[i] = ')';
                }

                else if (vetorNumericoParametro[i] == 1243)
                {
                    vetorCaracteres[i] = '*';
                }

                else if (vetorNumericoParametro[i] == 1244)
                {
                    vetorCaracteres[i] = '+';
                }

                else if (vetorNumericoParametro[i] == 1245)
                {
                    vetorCaracteres[i] = ',';
                }

                else if (vetorNumericoParametro[i] == 1246)
                {
                    vetorCaracteres[i] = '-';
                }

                else if (vetorNumericoParametro[i] == 1247)
                {
                    vetorCaracteres[i] = '.';
                }

                else if (vetorNumericoParametro[i] == 1248)
                {
                    vetorCaracteres[i] = '/';
                }

                else if (vetorNumericoParametro[i] == 4321)
                {
                    vetorCaracteres[i] = '0';
                }

                else if (vetorNumericoParametro[i] == 4320)
                {
                    vetorCaracteres[i] = '1';
                }

                else if (vetorNumericoParametro[i] == 4319)
                {
                    vetorCaracteres[i] = '2';
                }

                else if (vetorNumericoParametro[i] == 4318)
                {
                    vetorCaracteres[i] = '3';
                }

                else if (vetorNumericoParametro[i] == 4317)
                {
                    vetorCaracteres[i] = '4';
                }

                else if (vetorNumericoParametro[i] == 4316)
                {
                    vetorCaracteres[i] = '5';
                }

                else if (vetorNumericoParametro[i] == 4315)
                {
                    vetorCaracteres[i] = '6';
                }

                else if (vetorNumericoParametro[i] == 4314)
                {
                    vetorCaracteres[i] = '7';
                }

                else if (vetorNumericoParametro[i] == 4313)
                {
                    vetorCaracteres[i] = '8';
                }

                else if (vetorNumericoParametro[i] == 4312)
                {
                    vetorCaracteres[i] = '9';
                }

                else if (vetorNumericoParametro[i] == 201)
                {
                    vetorCaracteres[i] = ':';
                }

                else if (vetorNumericoParametro[i] == 202)
                {
                    vetorCaracteres[i] = ';';
                }

                else if (vetorNumericoParametro[i] == 203)
                {
                    vetorCaracteres[i] = '<';
                }

                else if (vetorNumericoParametro[i] == 204)
                {
                    vetorCaracteres[i] = '=';
                }

                else if (vetorNumericoParametro[i] == 205)
                {
                    vetorCaracteres[i] = '>';
                }

                else if (vetorNumericoParametro[i] == 206)
                {
                    vetorCaracteres[i] = '?';
                }

                else if (vetorNumericoParametro[i] == 207)
                {
                    vetorCaracteres[i] = '@';
                }

                else if (vetorNumericoParametro[i] == 9876)
                {
                    vetorCaracteres[i] = 'A';
                }

                else if (vetorNumericoParametro[i] == 9875)
                {
                    vetorCaracteres[i] = 'B';
                }

                else if (vetorNumericoParametro[i] == 9874)
                {
                    vetorCaracteres[i] = 'C';
                }

                else if (vetorNumericoParametro[i] == 9873)
                {
                    vetorCaracteres[i] = 'D';
                }

                else if (vetorNumericoParametro[i] == 9872)
                {
                    vetorCaracteres[i] = 'E';
                }

                else if (vetorNumericoParametro[i] == 9871)
                {
                    vetorCaracteres[i] = 'F';
                }

                else if (vetorNumericoParametro[i] == 9870)
                {
                    vetorCaracteres[i] = 'G';
                }

                else if (vetorNumericoParametro[i] == 9869)
                {
                    vetorCaracteres[i] = 'H';
                }

                else if (vetorNumericoParametro[i] == 9868)
                {
                    vetorCaracteres[i] = 'I';
                }

                else if (vetorNumericoParametro[i] == 9867)
                {
                    vetorCaracteres[i] = 'J';
                }

                else if (vetorNumericoParametro[i] == 9866)
                {
                    vetorCaracteres[i] = 'K';
                }

                else if (vetorNumericoParametro[i] == 9865)
                {
                    vetorCaracteres[i] = 'L';
                }

                else if (vetorNumericoParametro[i] == 9864)
                {
                    vetorCaracteres[i] = 'M';
                }

                else if (vetorNumericoParametro[i] == 9863)
                {
                    vetorCaracteres[i] = 'N';
                }

                else if (vetorNumericoParametro[i] == 9862)
                {
                    vetorCaracteres[i] = 'O';
                }

                else if (vetorNumericoParametro[i] == 9861)
                {
                    vetorCaracteres[i] = 'P';
                }

                else if (vetorNumericoParametro[i] == 9860)
                {
                    vetorCaracteres[i] = 'Q';
                }

                else if (vetorNumericoParametro[i] == 9859)
                {
                    vetorCaracteres[i] = 'R';
                }

                else if (vetorNumericoParametro[i] == 9858)
                {
                    vetorCaracteres[i] = 'S';
                }

                else if (vetorNumericoParametro[i] == 9857)
                {
                    vetorCaracteres[i] = 'T';
                }

                else if (vetorNumericoParametro[i] == 9856)
                {
                    vetorCaracteres[i] = 'U';
                }

                else if (vetorNumericoParametro[i] == 9855)
                {
                    vetorCaracteres[i] = 'V';
                }

                else if (vetorNumericoParametro[i] == 9854)
                {
                    vetorCaracteres[i] = 'W';
                }

                else if (vetorNumericoParametro[i] == 9853)
                {
                    vetorCaracteres[i] = 'X';
                }

                else if (vetorNumericoParametro[i] == 9852)
                {
                    vetorCaracteres[i] = 'Y';
                }

                else if (vetorNumericoParametro[i] == 9851)
                {
                    vetorCaracteres[i] = 'Z';
                }

                else if (vetorNumericoParametro[i] == 101)
                {
                    vetorCaracteres[i] = '[';
                }

                else if (vetorNumericoParametro[i] == 101)
                {
                    vetorCaracteres[i] = '[';
                }

                else if (vetorNumericoParametro[i] == 102)
                {
                    vetorCaracteres[i] = '\\';
                }

                else if (vetorNumericoParametro[i] == 103)
                {
                    vetorCaracteres[i] = ']';
                }

                else if (vetorNumericoParametro[i] == 104)
                {
                    vetorCaracteres[i] = '^';
                }

                else if (vetorNumericoParametro[i] == 105)
                {
                    vetorCaracteres[i] = '_';
                }

                else if (vetorNumericoParametro[i] == 6789)
                {
                    vetorCaracteres[i] = 'a';
                }

                else if (vetorNumericoParametro[i] == 6788)
                {
                    vetorCaracteres[i] = 'b';
                }

                else if (vetorNumericoParametro[i] == 6787)
                {
                    vetorCaracteres[i] = 'c';
                }

                else if (vetorNumericoParametro[i] == 6786)
                {
                    vetorCaracteres[i] = 'd';
                }

                else if (vetorNumericoParametro[i] == 6785)
                {
                    vetorCaracteres[i] = 'e';
                }

                else if (vetorNumericoParametro[i] == 6784)
                {
                    vetorCaracteres[i] = 'f';
                }

                else if (vetorNumericoParametro[i] == 6783)
                {
                    vetorCaracteres[i] = 'g';
                }

                else if (vetorNumericoParametro[i] == 6782)
                {
                    vetorCaracteres[i] = 'h';
                }

                else if (vetorNumericoParametro[i] == 6781)
                {
                    vetorCaracteres[i] = 'i';
                }

                else if (vetorNumericoParametro[i] == 6780)
                {
                    vetorCaracteres[i] = 'j';
                }

                else if (vetorNumericoParametro[i] == 6779)
                {
                    vetorCaracteres[i] = 'k';
                }

                else if (vetorNumericoParametro[i] == 6778)
                {
                    vetorCaracteres[i] = 'l';
                }

                else if (vetorNumericoParametro[i] == 6777)
                {
                    vetorCaracteres[i] = 'm';
                }

                else if (vetorNumericoParametro[i] == 6776)
                {
                    vetorCaracteres[i] = 'n';
                }

                else if (vetorNumericoParametro[i] == 6775)
                {
                    vetorCaracteres[i] = 'o';
                }

                else if (vetorNumericoParametro[i] == 6774)
                {
                    vetorCaracteres[i] = 'p';
                }

                else if (vetorNumericoParametro[i] == 6773)
                {
                    vetorCaracteres[i] = 'q';
                }

                else if (vetorNumericoParametro[i] == 6772)
                {
                    vetorCaracteres[i] = 'r';
                }

                else if (vetorNumericoParametro[i] == 6771)
                {
                    vetorCaracteres[i] = 's';
                }

                else if (vetorNumericoParametro[i] == 6770)
                {
                    vetorCaracteres[i] = 't';
                }

                else if (vetorNumericoParametro[i] == 6769)
                {
                    vetorCaracteres[i] = 'u';
                }

                else if (vetorNumericoParametro[i] == 6768)
                {
                    vetorCaracteres[i] = 'v';
                }

                else if (vetorNumericoParametro[i] == 6767)
                {
                    vetorCaracteres[i] = 'w';
                }

                else if (vetorNumericoParametro[i] == 6766)
                {
                    vetorCaracteres[i] = 'x';
                }

                else if (vetorNumericoParametro[i] == 6765)
                {
                    vetorCaracteres[i] = 'y';
                }

                else if (vetorNumericoParametro[i] == 6764)
                {
                    vetorCaracteres[i] = 'z';
                }

                else if (vetorNumericoParametro[i] == 301)
                {
                    vetorCaracteres[i] = '{';
                }

                else if (vetorNumericoParametro[i] == 302)
                {
                    vetorCaracteres[i] = '|';
                }

                else if (vetorNumericoParametro[i] == 303)
                {
                    vetorCaracteres[i] = '}';
                }

                else if (vetorNumericoParametro[i] == 304)
                {
                    vetorCaracteres[i] = '~';
                }
                
                // Caso o número resultado não corresponda a um caractere da lista, o espaço será preenchido com 'ç'
                else
                {
                    vetorCaracteres[i] = 'ç';
                }
            }

            // Função Join concatena os caracteres do vetor na string
            textoResultado = string.Join("", vetorCaracteres);

            return textoResultado;
        }
    }
}
