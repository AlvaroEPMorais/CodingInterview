using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Dictionary<string,int> testString = new Dictionary<string, int>();
            for (int i = 0; i < N; ++i)
            {
                String str = Console.ReadLine();
                if (testString.ContainsKey(str))
                {
                    testString[str] = testString[str] + 1;
                }
                else
                {
                    testString.Add(str,1);
                }
            }
            int Q = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Q; ++i)
            {
                String str = Console.ReadLine();
                if (testString.ContainsKey(str))
                {
                    Console.WriteLine(testString[str]);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
