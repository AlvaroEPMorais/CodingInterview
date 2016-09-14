using System;

namespace _2DArray_DS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arr = new int[6][];
            for (var arr_i = 0; arr_i < 6; arr_i++)
            {
                var arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, int.Parse);
            }
            int x = 0, y = 0;
            int sum = 0, sumMax = int.MinValue;
            while (true)
            {
                if (x + 2 >= arr.Length || y + 2 >= arr[0].Length)
                {
                    x = x + 1;
                    y = 0;
                    if (x + 2 >= arr.GetLength(0))
                    {
                        break;
                    }
                }
                Console.WriteLine("x = " + x + " y= " + y + " arr[x][y]= " + arr[x][y] + " sumMax= " + sumMax);
                sum = arr[x][y] + arr[x][y + 1] + arr[x][y + 2] + arr[x + 1][y + 1] + arr[x + 2][y] + arr[x + 2][y + 1] +
                      arr[x + 2][y + 2];
                if (sum > sumMax)
                {
                    sumMax = sum;
                }
                y = y + 1;
            }
            Console.WriteLine(sumMax);
        }
    }
}