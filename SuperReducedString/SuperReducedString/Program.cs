using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            bool flag = true;
            int index = 0;
            while (true)
            {
                if (index + 1 < str.Length && str[index] == str[index + 1])
                {
                    str = str.Substring(0, index) + str.Substring(index + 2);
                    flag = true;
                }
                if (str.Length == 0)
                {
                    break;
                }
                index = (index + 1) % str.Length;
                if (index == 0 )
                {
                    if (flag)
                    {
                        flag = false;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(str.Length > 0 ? str : "Empty String");
        }
    }
}
