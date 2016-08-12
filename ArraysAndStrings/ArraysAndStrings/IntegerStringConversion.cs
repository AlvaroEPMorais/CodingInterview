using System;
using System.Text;

namespace ArraysAndStrings
{
    internal static class IntegerStringConversion
    {
        public static String IntToString(int num)
        {
            StringBuilder strBu = new StringBuilder();
            bool neg = false;
            if (num < 0)
            {
                neg = num < 0;
                num = num * -1;
            }
            while (num > 0)
            {
                strBu.Append(num % 10);
                num = num / 10;
            }

            return neg ? "-" + strBu : strBu.ToString();
        }

        public static int StringToInt(String strnum)
        {
            int num = 0;
            int multi = 1;
            for (int i = strnum.Length - 1; i >= 0; --i)
            {
                char ch = strnum[i];
                if (Char.IsDigit(ch))
                {
                    int aux = ch - '0';
                    num = num + (aux * multi);
                    multi = multi * 10;
                }
            }
            if (strnum[0] == '-')
            {
                num = num * -1;
            }
            return num;
        }
    }
}