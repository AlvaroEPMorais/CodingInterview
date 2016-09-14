using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class MergingTwoArraysInOrder
    {
        //[1,3,5,7,9] + [2,4,6,8] == [1,2,3,4,5,6,7,8,9]
        public static int[] Method_1(int[] array1, int[] array2)
        {
            if (array1.Length == 0 && array2.Length == 0)
            {
                return new int[0];
            }
            if (array1.Length == 0 && array2.Length > 0)
            {
                return array2;
            }
            if (array2.Length == 0 && array1.Length > 0)
            {
                return array1;
            }

            int[] res = new int[array1.Length + array2.Length];
            int index = 0, index1 = 0, index2 = 0;
            while (index1 < array1.Length && index2 < array2.Length)
            {
                int num1 =  array1[index1];
                int num2 =  array2[index2];
                if (num1 < num2  )
                {
                    res[index] = num1;
                    ++index1;
                }
                if ( num2 < num1 )
                {
                    res[index] = num2;
                    ++index2;
                }
                ++index;
            }
            while (index1 < array1.Length)
            {
                res[index++] = array1[index1++];
            }
            while (index2 < array2.Length)
            {
                res[index++] = array2[index2++];
            }
            return res;
        }
    }
}
