using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    //Substituir todos os espaços por %20
    public static class URLify
    {
        public static string Method_1(String str)
        {
            //Verificar parametros de entrada
            if (String.IsNullOrWhiteSpace(str))
            {
                return String.Empty;
            }
            //construir string de acordo com as regras neste caso " " -> "%20"
            StringBuilder strB = new StringBuilder();
            foreach (char ch in str)
            {
                if (Char.IsWhiteSpace(ch))
                {
                    strB.Append("%20");
                }
                else
                {
                    strB.Append(ch);
                }
            }
            return strB.ToString();
        }

        public static void BookSolution(char[] str, int leng)
        {
            int spaceCount = 0, newLength, i;
            for ( i = 0; i < leng; i++)
            {
                if (str[i] == ' ')
                    spaceCount++;
            }
            newLength = leng + spaceCount*2;
            str[newLength] = '\0';
            for (i = leng - 1; i >= 0; --i)
            {
                if (str[i] == ' ')
                {
                    str[newLength - 1] = '0';
                    str[newLength - 2] = '2';
                    str[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    str[newLength - 1] = str[i];
                    newLength = newLength - 1;
                }
            }
        }
    }
}
