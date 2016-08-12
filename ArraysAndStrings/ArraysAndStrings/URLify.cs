using System;
using System.Text;

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
    }
}