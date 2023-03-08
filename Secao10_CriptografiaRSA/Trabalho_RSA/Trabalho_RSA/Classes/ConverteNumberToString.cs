/*
----- Tabela não ASCII -----
0 ou 96             ' ' (espaço)
1 ou 97             !	
2 ou 98	            " (aspas duplas)
3 ou 99	            #	
4 ou 100            $	
5 ou 101	        %	
6 ou 102	        &	
7 ou 103	        ' apóstrofe (aspas simples)
8 ou 104	        (	
9 ou 105	        )	
10 ou 106	        *	
11 ou 107	        +	
12 ou 108	        ,
13 ou 109	        -
14 ou 110	        .
15 ou 111	        /	
16 ou 112	        0	
17 ou 113	        1	
18 ou 114	        2	
19 ou 115	        3	
20 ou 116	        4	
21 ou 117	        5	
22 ou 118	        6	
23 ou 119	        7	
24 ou 120	        8	
25 ou 121	        9	
26 ou 122	        :	
27 ou 123	        ;	
28 ou 124	        <	
29 ou 125	        =	
30 ou 126	        >	
31 ou 127	        ?	
32 ou 128 	        @	
33 ou 129	        A	
34 ou 130	        B	
35 ou 131	        C	
36 ou 132	        D	
37 ou 133	        E	
38 ou 134	        F	
39 ou 135	        G	
40 ou 136	        H	
41 ou 137	        I	
42 ou 138	        J	
43 ou 139	        K	
44 ou 140	        L	
45 ou 141	        M	
46 ou 142	        N	
47 ou 143	        O	
48 ou 144	        P	
49 ou 145	        Q	
50 ou 146	        R	
51 ou 147	        S	
52 ou 148	        T	
53 ou 149	        U	
54 ou 150	        V	
55 ou 151	        W	
56 ou 152	        X	
57 ou 153	        Y	
58 ou 154	        Z
59 ou 155           Ã
60 ou 156	        [	
61 ou 157	        \	
62 ou 158	        ]	
63 ou 159	        ^	
64 ou 160	        _ (underscore)
65 ou 161	        a	
66 ou 162	        b	
67 ou 163	        c	
68 ou 164	        d	
69 ou 165           e	
70 ou 166	        f	
71 ou 167	        g	
72 ou 168           h	
73 ou 169	        i	
74 ou 170	        j	
75 ou 171	        k	
76 ou 172	        l	
77 ou 173	        m	
78 ou 174	        n	
79 ou 175	        o	
80 ou 176	        p	
81 ou 177	        q	
82 ou 178	        r	
83 ou 179	        s	
84 ou 180	        t	
85 ou 181	        u	
86 ou 182	        v	
87 ou 183	        w	
88 ou 184	        x	
89 ou 185	        y	
90 ou 186	        z
91 ou 187           ã
92 ou 188	        {	
93 ou 189	        |	
94 ou 190	        }	
95 ou 191	        ~
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
                if (vetorNumericoParametro[i] == 0 || vetorNumericoParametro[i] == 96)
                {
                    vetorCaracteres[i] = ' ';
                }

                else if (vetorNumericoParametro[i] == 1 || vetorNumericoParametro[i] == 97)
                {
                    vetorCaracteres[i] = '!';
                }

                else if (vetorNumericoParametro[i] == 2 || vetorNumericoParametro[i] == 98)
                {
                    vetorCaracteres[i] = '\"'; // aspas duplas
                }

                else if (vetorNumericoParametro[i] == 3 || vetorNumericoParametro[i] == 99)
                {
                    vetorCaracteres[i] = '#';
                }

                else if (vetorNumericoParametro[i] == 4 || vetorNumericoParametro[i] == 100)
                {
                    vetorCaracteres[i] = '$';
                }

                else if (vetorNumericoParametro[i] == 5 || vetorNumericoParametro[i] == 101)
                {
                    vetorCaracteres[i] = '%';
                }

                else if (vetorNumericoParametro[i] == 6 || vetorNumericoParametro[i] == 102)
                {
                    vetorCaracteres[i] = '&';
                }

                else if (vetorNumericoParametro[i] == 7 || vetorNumericoParametro[i] == 103) // aspas simples
                {
                    vetorCaracteres[i] = '\'';
                }

                else if (vetorNumericoParametro[i] == 8 || vetorNumericoParametro[i] == 104)
                {
                    vetorCaracteres[i] = '(';
                }

                else if (vetorNumericoParametro[i] == 9 || vetorNumericoParametro[i] == 105)
                {
                    vetorCaracteres[i] = ')';
                }

                else if (vetorNumericoParametro[i] == 10 || vetorNumericoParametro[i] == 106)
                {
                    vetorCaracteres[i] = '*';
                }

                else if (vetorNumericoParametro[i] == 11 || vetorNumericoParametro[i] == 107)
                {
                    vetorCaracteres[i] = '+';
                }

                else if (vetorNumericoParametro[i] == 12 || vetorNumericoParametro[i] == 108)
                {
                    vetorCaracteres[i] = ',';
                }

                else if (vetorNumericoParametro[i] == 13 || vetorNumericoParametro[i] == 109)
                {
                    vetorCaracteres[i] = '-';
                }

                else if (vetorNumericoParametro[i] == 14 || vetorNumericoParametro[i] == 110)
                {
                    vetorCaracteres[i] = '.';
                }

                else if (vetorNumericoParametro[i] == 15 || vetorNumericoParametro[i] == 111)
                {
                    vetorCaracteres[i] = '/';
                }

                else if (vetorNumericoParametro[i] == 16 || vetorNumericoParametro[i] == 112)
                {
                    vetorCaracteres[i] = '0';
                }

                else if (vetorNumericoParametro[i] == 17 || vetorNumericoParametro[i] == 113)
                {
                    vetorCaracteres[i] = '1';
                }

                else if (vetorNumericoParametro[i] == 18 || vetorNumericoParametro[i] == 114)
                {
                    vetorCaracteres[i] = '2';
                }

                else if (vetorNumericoParametro[i] == 19 || vetorNumericoParametro[i] == 115)
                {
                    vetorCaracteres[i] = '3';
                }

                else if (vetorNumericoParametro[i] == 20 || vetorNumericoParametro[i] == 116)
                {
                    vetorCaracteres[i] = '4';
                }

                else if (vetorNumericoParametro[i] == 21 || vetorNumericoParametro[i] == 117)
                {
                    vetorCaracteres[i] = '5';
                }

                else if (vetorNumericoParametro[i] == 22 || vetorNumericoParametro[i] == 118)
                {
                    vetorCaracteres[i] = '6';
                }

                else if (vetorNumericoParametro[i] == 23 || vetorNumericoParametro[i] == 119)
                {
                    vetorCaracteres[i] = '7';
                }

                else if (vetorNumericoParametro[i] == 24 || vetorNumericoParametro[i] == 120)
                {
                    vetorCaracteres[i] = '8';
                }

                else if (vetorNumericoParametro[i] == 25 || vetorNumericoParametro[i] == 121)
                {
                    vetorCaracteres[i] = '9';
                }

                else if (vetorNumericoParametro[i] == 26 || vetorNumericoParametro[i] == 122)
                {
                    vetorCaracteres[i] = ':';
                }

                else if (vetorNumericoParametro[i] == 27 || vetorNumericoParametro[i] == 123)
                {
                    vetorCaracteres[i] = ';';
                }

                else if (vetorNumericoParametro[i] == 28 || vetorNumericoParametro[i] == 124)
                {
                    vetorCaracteres[i] = '<';
                }

                else if (vetorNumericoParametro[i] == 29 || vetorNumericoParametro[i] == 125)
                {
                    vetorCaracteres[i] = '=';
                }

                else if (vetorNumericoParametro[i] == 30 || vetorNumericoParametro[i] == 126)
                {
                    vetorCaracteres[i] = '>';
                }

                else if (vetorNumericoParametro[i] == 31 || vetorNumericoParametro[i] == 127)
                {
                    vetorCaracteres[i] = '?';
                }

                else if (vetorNumericoParametro[i] == 32 || vetorNumericoParametro[i] == 128)
                {
                    vetorCaracteres[i] = '@';
                }

                else if (vetorNumericoParametro[i] == 33 || vetorNumericoParametro[i] == 129)
                {
                    vetorCaracteres[i] = 'A';
                }

                else if (vetorNumericoParametro[i] == 34 || vetorNumericoParametro[i] == 130)
                {
                    vetorCaracteres[i] = 'B';
                }

                else if (vetorNumericoParametro[i] == 35 || vetorNumericoParametro[i] == 131)
                {
                    vetorCaracteres[i] = 'C';
                }

                else if (vetorNumericoParametro[i] == 36 || vetorNumericoParametro[i] == 132)
                {
                    vetorCaracteres[i] = 'D';
                }

                else if (vetorNumericoParametro[i] == 37 || vetorNumericoParametro[i] == 133)
                {
                    vetorCaracteres[i] = 'E';
                }

                else if (vetorNumericoParametro[i] == 38 || vetorNumericoParametro[i] == 134)
                {
                    vetorCaracteres[i] = 'F';
                }

                else if (vetorNumericoParametro[i] == 39 || vetorNumericoParametro[i] == 135)
                {
                    vetorCaracteres[i] = 'G';
                }

                else if (vetorNumericoParametro[i] == 40 || vetorNumericoParametro[i] == 136)
                {
                    vetorCaracteres[i] = 'H';
                }

                else if (vetorNumericoParametro[i] == 41 || vetorNumericoParametro[i] == 137)
                {
                    vetorCaracteres[i] = 'I';
                }

                else if (vetorNumericoParametro[i] == 42 || vetorNumericoParametro[i] == 138)
                {
                    vetorCaracteres[i] = 'J';
                }

                else if (vetorNumericoParametro[i] == 43 || vetorNumericoParametro[i] == 139)
                {
                    vetorCaracteres[i] = 'K';
                }

                else if (vetorNumericoParametro[i] == 44 || vetorNumericoParametro[i] == 140)
                {
                    vetorCaracteres[i] = 'L';
                }

                else if (vetorNumericoParametro[i] == 45 || vetorNumericoParametro[i] == 141)
                {
                    vetorCaracteres[i] = 'M';
                }

                else if (vetorNumericoParametro[i] == 46 || vetorNumericoParametro[i] == 142)
                {
                    vetorCaracteres[i] = 'N';
                }

                else if (vetorNumericoParametro[i] == 47 || vetorNumericoParametro[i] == 143)
                {
                    vetorCaracteres[i] = 'O';
                }

                else if (vetorNumericoParametro[i] == 48 || vetorNumericoParametro[i] == 144)
                {
                    vetorCaracteres[i] = 'P';
                }

                else if (vetorNumericoParametro[i] == 49 || vetorNumericoParametro[i] == 145)
                {
                    vetorCaracteres[i] = 'Q';
                }

                else if (vetorNumericoParametro[i] == 50 || vetorNumericoParametro[i] == 146)
                {
                    vetorCaracteres[i] = 'R';
                }

                else if (vetorNumericoParametro[i] == 51 || vetorNumericoParametro[i] == 147)
                {
                    vetorCaracteres[i] = 'S';
                }

                else if (vetorNumericoParametro[i] == 52 || vetorNumericoParametro[i] == 148)
                {
                    vetorCaracteres[i] = 'T';
                }

                else if (vetorNumericoParametro[i] == 53 || vetorNumericoParametro[i] == 149)
                {
                    vetorCaracteres[i] = 'U';
                }

                else if (vetorNumericoParametro[i] == 54 || vetorNumericoParametro[i] == 150)
                {
                    vetorCaracteres[i] = 'V';
                }

                else if (vetorNumericoParametro[i] == 55 || vetorNumericoParametro[i] == 151)
                {
                    vetorCaracteres[i] = 'W';
                }

                else if (vetorNumericoParametro[i] == 56 || vetorNumericoParametro[i] == 152)
                {
                    vetorCaracteres[i] = 'X';
                }

                else if (vetorNumericoParametro[i] == 57 || vetorNumericoParametro[i] == 153)
                {
                    vetorCaracteres[i] = 'Y';
                }

                else if (vetorNumericoParametro[i] == 58 || vetorNumericoParametro[i] == 154)
                {
                    vetorCaracteres[i] = 'Z';
                }

                else if (vetorNumericoParametro[i] == 59 || vetorNumericoParametro[i] == 155)
                {
                    vetorCaracteres[i] = 'Â';
                }

                else if (vetorNumericoParametro[i] == 60 || vetorNumericoParametro[i] == 156)
                {
                    vetorCaracteres[i] = '[';
                }

                else if (vetorNumericoParametro[i] == 61 || vetorNumericoParametro[i] == 157)
                {
                    vetorCaracteres[i] = '\\';
                }

                else if (vetorNumericoParametro[i] == 62 || vetorNumericoParametro[i] == 158)
                {
                    vetorCaracteres[i] = ']';
                }

                else if (vetorNumericoParametro[i] == 63 || vetorNumericoParametro[i] == 159)
                {
                    vetorCaracteres[i] = '^';
                }

                else if (vetorNumericoParametro[i] == 64 || vetorNumericoParametro[i] == 160)
                {
                    vetorCaracteres[i] = '_';
                }

                else if (vetorNumericoParametro[i] == 65 || vetorNumericoParametro[i] == 161)
                {
                    vetorCaracteres[i] = 'a';
                }

                else if (vetorNumericoParametro[i] == 66 || vetorNumericoParametro[i] == 162)
                {
                    vetorCaracteres[i] = 'b';
                }

                else if (vetorNumericoParametro[i] == 67 || vetorNumericoParametro[i] == 163)
                {
                    vetorCaracteres[i] = 'c';
                }

                else if (vetorNumericoParametro[i] == 68 || vetorNumericoParametro[i] == 164)
                {
                    vetorCaracteres[i] = 'd';
                }

                else if (vetorNumericoParametro[i] == 69 || vetorNumericoParametro[i] == 165)
                {
                    vetorCaracteres[i] = 'e';
                }

                else if (vetorNumericoParametro[i] == 70 || vetorNumericoParametro[i] == 166)
                {
                    vetorCaracteres[i] = 'f';
                }

                else if (vetorNumericoParametro[i] == 71 || vetorNumericoParametro[i] == 167)
                {
                    vetorCaracteres[i] = 'g';
                }

                else if (vetorNumericoParametro[i] == 72 || vetorNumericoParametro[i] == 168)
                {
                    vetorCaracteres[i] = 'h';
                }

                else if (vetorNumericoParametro[i] == 73 || vetorNumericoParametro[i] == 169)
                {
                    vetorCaracteres[i] = 'i';
                }

                else if (vetorNumericoParametro[i] == 74 || vetorNumericoParametro[i] == 170)
                {
                    vetorCaracteres[i] = 'j';
                }

                else if (vetorNumericoParametro[i] == 75 || vetorNumericoParametro[i] == 171)
                {
                    vetorCaracteres[i] = 'k';
                }

                else if (vetorNumericoParametro[i] == 76 || vetorNumericoParametro[i] == 172)
                {
                    vetorCaracteres[i] = 'l';
                }

                else if (vetorNumericoParametro[i] == 77 || vetorNumericoParametro[i] == 173)
                {
                    vetorCaracteres[i] = 'm';
                }

                else if (vetorNumericoParametro[i] == 78 || vetorNumericoParametro[i] == 174)
                {
                    vetorCaracteres[i] = 'n';
                }

                else if (vetorNumericoParametro[i] == 79 || vetorNumericoParametro[i] == 175)
                {
                    vetorCaracteres[i] = 'o';
                }

                else if (vetorNumericoParametro[i] == 80 || vetorNumericoParametro[i] == 176)
                {
                    vetorCaracteres[i] = 'p';
                }

                else if (vetorNumericoParametro[i] == 81 || vetorNumericoParametro[i] == 177)
                {
                    vetorCaracteres[i] = 'q';
                }

                else if (vetorNumericoParametro[i] == 82 || vetorNumericoParametro[i] == 178)
                {
                    vetorCaracteres[i] = 'r';
                }

                else if (vetorNumericoParametro[i] == 83 || vetorNumericoParametro[i] == 179)
                {
                    vetorCaracteres[i] = 's';
                }

                else if (vetorNumericoParametro[i] == 84 || vetorNumericoParametro[i] == 180)
                {
                    vetorCaracteres[i] = 't';
                }

                else if (vetorNumericoParametro[i] == 85 || vetorNumericoParametro[i] == 181)
                {
                    vetorCaracteres[i] = 'u';
                }

                else if (vetorNumericoParametro[i] == 86 || vetorNumericoParametro[i] == 182)
                {
                    vetorCaracteres[i] = 'v';
                }

                else if (vetorNumericoParametro[i] == 87 || vetorNumericoParametro[i] == 183)
                {
                    vetorCaracteres[i] = 'w';
                }

                else if (vetorNumericoParametro[i] == 88 || vetorNumericoParametro[i] == 184)
                {
                    vetorCaracteres[i] = 'x';
                }

                else if (vetorNumericoParametro[i] == 89 || vetorNumericoParametro[i] == 185)
                {
                    vetorCaracteres[i] = 'y';
                }

                else if (vetorNumericoParametro[i] == 90 || vetorNumericoParametro[i] == 186)
                {
                    vetorCaracteres[i] = 'z';
                }
                
                else if (vetorNumericoParametro[i] == 91 || vetorNumericoParametro[i] == 187)
                {
                    vetorCaracteres[i] = 'ã';
                }

                else if (vetorNumericoParametro[i] == 92 || vetorNumericoParametro[i] == 188)
                {
                    vetorCaracteres[i] = '{';
                }

                else if (vetorNumericoParametro[i] == 93 || vetorNumericoParametro[i] == 189)
                {
                    vetorCaracteres[i] = '|';
                }

                else if (vetorNumericoParametro[i] == 94 || vetorNumericoParametro[i] == 190)
                {
                    vetorCaracteres[i] = '}';
                }

                else if (vetorNumericoParametro[i] == 95 || vetorNumericoParametro[i] == 191)
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
