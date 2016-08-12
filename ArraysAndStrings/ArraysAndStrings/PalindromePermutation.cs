using System;

namespace ArraysAndStrings
{
    public static class PalindromePermutation
    {
        public static bool Method_1(String permu)
        {
            //Verificar parametros de entrada
            if (String.IsNullOrWhiteSpace(permu))
            {
                return true;
            }
            if (permu.Length < 1)
            {
                return true;
            }
            int[] array = new int[256];
            foreach (var ch in permu.ToLowerInvariant())
            {
                array[ch]++;
            }
            bool uniq = false;
            foreach (var num in array)
            {
                if (array[num] % 2 == 0)
                    continue;
                if (array[num] == 1 || array[num] % 2 != 0)
                {
                    if (!uniq)
                        uniq = true;
                    else
                        return false;
                }
            }
            return true;
        }

        public static bool Method_2(String permu)
        {
            //Verificar parametros de entrada
            if (String.IsNullOrWhiteSpace(permu))
            {
                return true;
            }
            if (permu.Length < 1)
            {
                return true;
            }
            bool[] array = new bool[256];
            foreach (char ch in permu.ToLowerInvariant())
            {
                if (!Char.IsWhiteSpace(ch))
                {
                    array[ch] = !array[ch];
                }
            }
            bool boo = false;
            foreach (var varBoo in array)
            {
                if (varBoo)
                {
                    if (!boo)
                    {
                        boo = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}