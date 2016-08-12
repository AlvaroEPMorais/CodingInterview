using System;

namespace ArraysAndStrings
{
    internal static class OneWay
    {
        public static bool Method_1(String str1, String str2)
        {
            if (String.IsNullOrWhiteSpace(str1) || String.IsNullOrWhiteSpace(str2))
            {
                return false;
            }
            if (Math.Abs(str1.Length - str2.Length) > 1)
            {
                return false;
            }
            int[] arrayCnt = new int[256];
            foreach (var ch in str1)
            {
                arrayCnt[ch]++;
            }
            foreach (var ch in str2)
            {
                arrayCnt[ch]--;
                if (arrayCnt[ch] < -1)
                    return false;
            }
            int numPos = 0;
            int numNeg = 0;
            foreach (var num in arrayCnt)
            {
                if (num == 1)
                    numPos++;
                if (num == -1)
                    numNeg++;
                if (numPos > 1 || numNeg > 1)
                    return false;
            }
            return true;
        }

        public static bool BestSolution(String first, String second)
        {
            if (first.Length == second.Length)
            {
                return OneEditReplace(first, second);
            }
            if (first.Length + 1 == second.Length)
            {
                return OneEditInsert(first, second);
            }
            if (first.Length - 1 == second.Length)
            {
                return OneEditInsert(second, first);
            }
            return false;
        }

        private static bool OneEditInsert(string first, string second)
        {
            int index1 = 0;
            int index2 = 0;
            while (index2 < second.Length && index1 < first.Length)
            {
                if (first[index1] != second[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index2++;
                    index1++;
                }
            }
            return true;
        }

        private static bool OneEditReplace(string first, string second)
        {
            bool foundDifference = false;
            for (int i = 0; i < first.Length; ++i)
            {
                if (first[i] != second[i])
                {
                    if (foundDifference)
                    {
                        return false;
                    }
                    foundDifference = true;
                }
            }
            return true;
        }
    }
}