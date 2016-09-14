using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

internal class Solution
{
    private static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        StringBuilder retStr = new StringBuilder();
        HashSet<String> mySet = new HashSet<String>();
        foreach (string line in File.ReadLines(@"../../dictionary.lst"))
        {
            mySet.Add(line.ToLower().Trim());        
        }
        String[] cTxt = Console.ReadLine().ToLower().Split(' ');
        int offSet = 0;
        while (offSet < alphabet.Length)
        {
            ++offSet;
            retStr.Clear();
            for (int i = 0; i < cTxt.Length; ++i)
            {
                String str = cTxt[i].Trim();
                String aux = String.Empty;
                foreach (char ch in str)
                {
                    int index = ch - 'a';
                    index = (index + offSet) % alphabet.Length;
                    aux = aux + alphabet[index];
                }
                retStr.Append(aux + " ");
                if (mySet.Contains(aux))
                {
                    Console.WriteLine("F*** " + aux);
                }
            }
            Console.WriteLine(retStr.ToString());
            Console.WriteLine(offSet + " ###################################");
        }
        Console.WriteLine(retStr.ToString());
    }
}