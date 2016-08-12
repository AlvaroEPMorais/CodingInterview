using System;
using System.Text;

namespace ArraysAndStrings
{
    internal static class ReverseWords
    {
        public static String Method_1(String str)
        {
            String[] allWords = str.Split(' ');
            StringBuilder strBu = new StringBuilder();
            for (int i = allWords.Length - 1; i >= 0; --i)
            {
                strBu.Append(allWords[i] + " ");
            }
            return strBu.ToString();
        }
    }
}