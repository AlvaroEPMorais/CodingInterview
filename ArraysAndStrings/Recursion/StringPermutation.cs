using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    //input: abc
    //output:
    //  abc
    //  acb
    //  bac
    //  bca
    //  cab
    //  cba
    public class StringPermutation
    {
        private int _stringLength = 0;
        private string _str = String.Empty;

        public StringPermutation(String str)
        {
            _str = str;
            _stringLength = str.Length;
            printResult(solve(str));

        }

        private void printResult(List<string> list)
        {
            int localCnt = 0;
            foreach (var str in list)
            {
                if (str.Length == _stringLength)
                {
                    Console.WriteLine(str);
                    ++localCnt;
                }
            }
            Console.WriteLine("Total perms ->"+list.Count+ " Valid perms -> "+ localCnt);
            Console.WriteLine("-------------------------");
        }

        private List<String> solve(string input)
        {
            List<String> perms = new List<string>();
            if (input.Length == 0)
            {
                perms.Add(String.Empty);
                return perms;
            }
            char prefix = input[0];
            String str = input.Substring(1);
            List<String> subString = solve(str);
            foreach (string s in subString)
            {
                for (int i = 0; i <= s.Length; i++)
                {
                    String beginning = s.Substring(0, i);
                    String middle = prefix.ToString();
                    String end = s.Substring(i);
                    perms.Add(beginning + middle + end);
                }
            }

            return perms;
        }
    }
}
