using System;
using System.Text;

internal class Solution
{
    private static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string B = Console.ReadLine();
        int cnt = 0;
        int flag = 0;
        if (B.Length < 3)
        {
            Console.WriteLine(cnt);
        }
        else if (B.Length == 3)
        {
            Console.WriteLine(cnt);
        }
        else if (B.Length > 3)
        {
            StringBuilder strBu = new StringBuilder(B);
            int index = 0;
            String str = strBu.ToString();
            Console.WriteLine(cnt + " # " + str);
            while (str.Contains("010"))
            {
                ++cnt;
                if (flag == 0)
                {
                    index = str.LastIndexOf("010", StringComparison.Ordinal) + 1;
                    strBu.Replace('1', '0', index, 1);
                }
                if (flag == 1)
                {
                    index = str.IndexOf("010", StringComparison.Ordinal) + 2;
                    strBu.Replace('0', '1', index, 1);
                }
                if (flag == 2)
                {
                    index = str.LastIndexOf("010", StringComparison.Ordinal);
                    strBu.Replace('0', '1', index, 1);
                }
                if (flag == 3)
                {
                    index = str.IndexOf("010", StringComparison.Ordinal) + 1;
                    strBu.Replace('1', '0', index, 1);
                }
                if (flag == 4)
                {
                    index = str.LastIndexOf("010", StringComparison.Ordinal) + 2;
                    strBu.Replace('0', '1', index, 1);
                }
                if (flag == 5)
                {
                    index = str.IndexOf("010", StringComparison.Ordinal);
                    strBu.Replace('0', '1', index, 1);
                }
                flag = (flag + 1) % 6;
                str = strBu.ToString();
                Console.WriteLine(cnt + " # " + str + " index-> " + index + " flag-> " + flag);
            }
        }
        Console.WriteLine(cnt);
    }
}