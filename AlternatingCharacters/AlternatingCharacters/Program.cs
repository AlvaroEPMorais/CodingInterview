using System;
using System.Globalization;

namespace AlternatingCharacters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
           
            int j=0;
            for (int index1 = 0; index1 < n; ++index1)
            {
                int cnt = 0;
                String s = Console.ReadLine();
                for (int i = 0; i < s.Length - 1; )
                {
                    char ch = s[i];
                    for (j = i + 1; j < s.Length; ++j)
                    {
                        if (ch == s[j])
                        {
                            ++cnt;
                        }
                        else
                        {
                            break;
                        }
                    }
                    i = j ;
                }
                Console.WriteLine(cnt);
            }
            
        }
    }
}