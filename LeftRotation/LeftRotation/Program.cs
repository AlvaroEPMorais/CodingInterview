using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        static void Main()
        {
            string args = Console.ReadLine();
            string[] argsArray = args.Split(' ');
            int n = Convert.ToInt32(argsArray[0]);
            int d = Convert.ToInt32(argsArray[1]);
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = new int[n];
            arr = Array.ConvertAll(arr_temp, int.Parse);
            d = d % arr.Length;
            int dim = arr.Length - (arr.Length - d);
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[dim] + " ");
                dim = (dim + 1) % arr.Length;
            }
        }
    }
}
