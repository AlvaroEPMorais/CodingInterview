using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndStrings
{
    internal static class FirstNonRepeatedCharacter
    {
        public static char Method_1(String str)
        {
            Dictionary<char, int> data = new Dictionary<char, int>();
            foreach (var ch in str)
            {
                if (data.ContainsKey(ch))
                    data[ch]++;
                else
                    data.Add(ch, 1);
            }
            return data.First(d => d.Value == 1).Key;
        }
    }
}