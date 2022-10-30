/*
----- Tabela não ASCII -----
0           ' ' (espaço)
1           !	
2	        " (aspas duplas)
3	        #	
4	        $	
5	        %	
6	        &	
7	        ' apóstrofe (aspas simples)
8	        (	
9	        )	
10	        *	
11	        +	
12	        ,
13	        -
14	        .
15	        /	
16	        0	
17	        1	
18	        2	
19	        3	
20	        4	
21	        5	
22	        6	
23	        7	
24	        8	
25	        9	
26	        :	
27	        ;	
28	        <	
29	        =	
30	        >	
31	        ?	
32 	        @	
33	        A	
34	        B	
35	        C	
36	        D	
37	        E	
38	        F	
39	        G	
40	        H	
41	        I	
42	        J	
43	        K	
44	        L	
45	        M	
46	        N	
47	        O	
48	        P	
49	        Q	
50	        R	
51	        S	
52	        T	
53	        U	
54	        V	
55	        W	
56	        X	
57	        Y	
58	        Z
59          Ã
60	        [	
61	        \	
62	        ]	
63	        ^	
64	        _ (underscore)
65	        a	
66	        b	
67	        c	
68	        d	
69          e	
70	        f	
71	        g	
72          h	
73	        i	
74	        j	
75	        k	
76	        l	
77	        m	
78	        n	
79	        o	
80	        p	
81	        q	
82	        r	
83	        s	
84	        t	
85	        u	
86	        v	
87	        w	
88	        x	
89	        y	
90	        z
91          ã
92	        {	
93	        |	
94	        }	
95	        ~
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

            for (int i = 0; i < textoParametro.Length; i++)
            {
                if (vetorTexto[i] == ' ')
                {
                    vetorInteiros[i] = 0;
                }

                else if (vetorTexto[i] == '!')
                {
                    vetorInteiros[i] = 1;
                }

                else if (vetorTexto[i] == '\"') // aspas duplas
                {
                    vetorInteiros[i] = 2;
                }

                else if (vetorTexto[i] == '#')
                {
                    vetorInteiros[i] = 3;
                }

                else if (vetorTexto[i] == '$')
                {
                    vetorInteiros[i] = 4;
                }

                else if (vetorTexto[i] == '%')
                {
                    vetorInteiros[i] = 5;
                }

                else if (vetorTexto[i] == '&')
                {
                    vetorInteiros[i] = 6;
                }

                else if (vetorTexto[i] == '\'') // aspas simples
                {
                    vetorInteiros[i] = 7;
                }

                else if (vetorTexto[i] == '(')
                {
                    vetorInteiros[i] = 8;
                }

                else if (vetorTexto[i] == ')')
                {
                    vetorInteiros[i] = 9;
                }

                else if (vetorTexto[i] == '*')
                {
                    vetorInteiros[i] = 10;
                }

                else if (vetorTexto[i] == '+')
                {
                    vetorInteiros[i] = 11;
                }

                else if (vetorTexto[i] == ',')
                {
                    vetorInteiros[i] = 12;
                }

                else if (vetorTexto[i] == '-')
                {
                    vetorInteiros[i] = 13;
                }

                else if (vetorTexto[i] == '.')
                {
                    vetorInteiros[i] = 14;
                }

                else if (vetorTexto[i] == '/')
                {
                    vetorInteiros[i] = 15;
                }

                else if (vetorTexto[i] == '0')
                {
                    vetorInteiros[i] = 16;
                }

                else if (vetorTexto[i] == '1')
                {
                    vetorInteiros[i] = 17;
                }

                else if (vetorTexto[i] == '2')
                {
                    vetorInteiros[i] = 18;
                }

                else if (vetorTexto[i] == '3')
                {
                    vetorInteiros[i] = 19;
                }

                else if (vetorTexto[i] == '4')
                {
                    vetorInteiros[i] = 20;
                }

                else if (vetorTexto[i] == '5')
                {
                    vetorInteiros[i] = 21;
                }

                else if (vetorTexto[i] == '6')
                {
                    vetorInteiros[i] = 22;
                }

                else if (vetorTexto[i] == '7')
                {
                    vetorInteiros[i] = 23;
                }

                else if (vetorTexto[i] == '8')
                {
                    vetorInteiros[i] = 24;
                }

                else if (vetorTexto[i] == '9')
                {
                    vetorInteiros[i] = 25;
                }

                else if (vetorTexto[i] == ':')
                {
                    vetorInteiros[i] = 26;
                }

                else if (vetorTexto[i] == ';')
                {
                    vetorInteiros[i] = 27;
                }

                else if (vetorTexto[i] == '<')
                {
                    vetorInteiros[i] = 28;
                }

                else if (vetorTexto[i] == '=')
                {
                    vetorInteiros[i] = 29;
                }

                else if (vetorTexto[i] == '>')
                {
                    vetorInteiros[i] = 30;
                }

                else if (vetorTexto[i] == '?')
                {
                    vetorInteiros[i] = 31;
                }

                else if (vetorTexto[i] == '@')
                {
                    vetorInteiros[i] = 32;
                }

                else if (vetorTexto[i] == 'A')
                {
                    vetorInteiros[i] = 33;
                }

                else if (vetorTexto[i] == 'B')
                {
                    vetorInteiros[i] = 34;
                }

                else if (vetorTexto[i] == 'C')
                {
                    vetorInteiros[i] = 35;
                }

                else if (vetorTexto[i] == 'D')
                {
                    vetorInteiros[i] = 36;
                }

                else if (vetorTexto[i] == 'E')
                {
                    vetorInteiros[i] = 37;
                }

                else if (vetorTexto[i] == 'F')
                {
                    vetorInteiros[i] = 38;
                }

                else if (vetorTexto[i] == 'G')
                {
                    vetorInteiros[i] = 39;
                }

                else if (vetorTexto[i] == 'H')
                {
                    vetorInteiros[i] = 40;
                }

                else if (vetorTexto[i] == 'I')
                {
                    vetorInteiros[i] = 41;
                }

                else if (vetorTexto[i] == 'J')
                {
                    vetorInteiros[i] = 42;
                }

                else if (vetorTexto[i] == 'K')
                {
                    vetorInteiros[i] = 43;
                }

                else if (vetorTexto[i] == 'L')
                {
                    vetorInteiros[i] = 44;
                }

                else if (vetorTexto[i] == 'M')
                {
                    vetorInteiros[i] = 45;
                }

                else if (vetorTexto[i] == 'N')
                {
                    vetorInteiros[i] = 46;
                }

                else if (vetorTexto[i] == 'O')
                {
                    vetorInteiros[i] = 47;
                }

                else if (vetorTexto[i] == 'P')
                {
                    vetorInteiros[i] = 48;
                }

                else if (vetorTexto[i] == 'Q')
                {
                    vetorInteiros[i] = 49;
                }

                else if (vetorTexto[i] == 'R')
                {
                    vetorInteiros[i] = 50;
                }

                else if (vetorTexto[i] == 'S')
                {
                    vetorInteiros[i] = 51;
                }

                else if (vetorTexto[i] == 'T')
                {
                    vetorInteiros[i] = 52;
                }

                else if (vetorTexto[i] == 'U')
                {
                    vetorInteiros[i] = 53;
                }

                else if (vetorTexto[i] == 'V')
                {
                    vetorInteiros[i] = 54;
                }

                else if (vetorTexto[i] == 'W')
                {
                    vetorInteiros[i] = 55;
                }

                else if (vetorTexto[i] == 'X')
                {
                    vetorInteiros[i] = 56;
                }

                else if (vetorTexto[i] == 'Y')
                {
                    vetorInteiros[i] = 57;
                }

                else if (vetorTexto[i] == 'Z')
                {
                    vetorInteiros[i] = 58;
                }

                else if (vetorTexto[i] == 'Ã')
                {
                    vetorInteiros[i] = 59;
                }

                else if (vetorTexto[i] == '[')
                {
                    vetorInteiros[i] = 60;
                }

                else if (vetorTexto[i] == '\\')
                {
                    vetorInteiros[i] = 61;
                }

                else if (vetorTexto[i] == ']')
                {
                    vetorInteiros[i] = 62;
                }

                else if (vetorTexto[i] == '^')
                {
                    vetorInteiros[i] = 63;
                }

                else if (vetorTexto[i] == '_')
                {
                    vetorInteiros[i] = 64;
                }

                else if (vetorTexto[i] == 'a')
                {
                    vetorInteiros[i] = 65;
                }

                else if (vetorTexto[i] == 'b')
                {
                    vetorInteiros[i] = 66;
                }

                else if (vetorTexto[i] == 'c')
                {
                    vetorInteiros[i] = 67;
                }

                else if (vetorTexto[i] == 'd')
                {
                    vetorInteiros[i] = 68;
                }

                else if (vetorTexto[i] == 'e')
                {
                    vetorInteiros[i] = 69;
                }

                else if (vetorTexto[i] == 'f')
                {
                    vetorInteiros[i] = 70;
                }

                else if (vetorTexto[i] == 'g')
                {
                    vetorInteiros[i] = 71;
                }

                else if (vetorTexto[i] == 'h')
                {
                    vetorInteiros[i] = 72;
                }

                else if (vetorTexto[i] == 'i')
                {
                    vetorInteiros[i] = 73;
                }

                else if (vetorTexto[i] == 'j')
                {
                    vetorInteiros[i] = 74;
                }

                else if (vetorTexto[i] == 'k')
                {
                    vetorInteiros[i] = 75;
                }

                else if (vetorTexto[i] == 'l')
                {
                    vetorInteiros[i] = 76;
                }

                else if (vetorTexto[i] == 'm')
                {
                    vetorInteiros[i] = 77;
                }

                else if (vetorTexto[i] == 'n')
                {
                    vetorInteiros[i] = 78;
                }

                else if (vetorTexto[i] == 'o')
                {
                    vetorInteiros[i] = 79;
                }

                else if (vetorTexto[i] == 'p')
                {
                    vetorInteiros[i] = 80;
                }

                else if (vetorTexto[i] == 'q')
                {
                    vetorInteiros[i] = 81;
                }

                else if (vetorTexto[i] == 'r')
                {
                    vetorInteiros[i] = 82;
                }

                else if (vetorTexto[i] == 's')
                {
                    vetorInteiros[i] = 83;
                }

                else if (vetorTexto[i] == 't')
                {
                    vetorInteiros[i] = 84;
                }

                else if (vetorTexto[i] == 'u')
                {
                    vetorInteiros[i] = 85;
                }

                else if (vetorTexto[i] == 'v')
                {
                    vetorInteiros[i] = 86;
                }

                else if (vetorTexto[i] == 'w')
                {
                    vetorInteiros[i] = 87;
                }

                else if (vetorTexto[i] == 'x')
                {
                    vetorInteiros[i] = 88;
                }

                else if (vetorTexto[i] == 'y')
                {
                    vetorInteiros[i] = 89;
                }

                else if (vetorTexto[i] == 'z')
                {
                    vetorInteiros[i] = 90;
                }

                else if (vetorTexto[i] == 'ã')
                {
                    vetorInteiros[i] = 91;
                }

                else if (vetorTexto[i] == '{')
                {
                    vetorInteiros[i] = 92;
                }

                else if (vetorTexto[i] == '|')
                {
                    vetorInteiros[i] = 93;
                }

                else if (vetorTexto[i] == '}')
                {
                    vetorInteiros[i] = 94;
                }

                else if (vetorTexto[i] == '~')
                {
                    vetorInteiros[i] = 95;
                }

                else
                {
                    vetorInteiros[i] = 96;
                }
            }
            
            return vetorInteiros;
        }
    }
}
