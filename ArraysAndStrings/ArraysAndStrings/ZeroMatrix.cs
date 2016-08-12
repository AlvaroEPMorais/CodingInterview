using System;
using System.Collections.Generic;

namespace ArraysAndStrings
{
    public static class ZeroMatrix
    {
        public static int[,] Method_1(int[,] matrix)
        {
            List<int> xList = new List<int>();
            List<int> yList = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(0); ++j)
                {
                    if (matrix[i, j] == 0)
                    {
                        xList.Add(i);
                        yList.Add(j);
                    }
                }
            }
            for (int index = 0; index < xList.Count; ++index)
            {
                int x = xList[index];
                int y = yList[index];
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    matrix[i, y] = 0;
                }
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    matrix[x, i] = 0;
                }
            }
            return matrix;
        }

        public static void showMatrix(this int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(3) + " |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("#############################################");
        }
    }
}