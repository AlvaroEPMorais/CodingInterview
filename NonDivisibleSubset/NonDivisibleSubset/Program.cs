using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonDivisibleSubset
{
    class Program
    {
        static void Main()
        {
            int n = 0, K = 0;
            int[] arr;
            using (StreamReader file = new StreamReader("../testCase_2.txt"))
            {
                string[] args = file.ReadLine().Split(' ');
                n = Convert.ToInt32(args[0]);
                K = Convert.ToInt32(args[1]);
                args = file.ReadLine().Split(' ');
                arr = new int[n];
                arr = Array.ConvertAll(args, int.Parse);
            }
            //string[] args = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(args[0]);
            //int k = Convert.ToInt32(args[1]);
            //args = Console.ReadLine().Split(' ');
            //int[] arr = new int[n];
            //arr = Array.ConvertAll(args, int.Parse);
            int[] remaiders = new int[n];
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                remaiders[i] = arr[i] % k;
            }
            for (int k = 1; k < (K/2) - 1; ++k)
            {
                
            }
        }
    }
}
