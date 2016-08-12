using System;
using System.Text;

namespace ArraysAndStrings
{
    public static class StringCompression
    {
        public static string Method_1(String str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return String.Empty;
            }
            StringBuilder ret = new StringBuilder();
            int cnt = 1;
            char chAct = str[0];

            for (int i = 1; i < str.Length; ++i)
            {
                char ch = str[i];
                if (chAct == ch)
                {
                    ++cnt;
                    continue;
                }

                ret.Append(chAct + cnt.ToString());
                chAct = ch;
                cnt = 1;
            }

            ret.Append(chAct + cnt.ToString());
            return ret.Length < str.Length ? ret.ToString() : str;
        }

        public static string BestSolution(String str)
        {
            StringBuilder compressed = new StringBuilder();
            int cnt = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                cnt++;
                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressed.Append(str[i]);
                    compressed.Append(cnt);
                    cnt = 0;
                }
            }
            return compressed.Length < str.Length ? compressed.ToString() : str;
        }
    }
}