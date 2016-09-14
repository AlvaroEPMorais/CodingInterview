using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class MaxDifferenceProblem
    {
        //Each integer can be imagined as a stock price at the end of the day.
        //At what day should you buy/sell in order to make the maximum profit
        //input [-1, 5, 0, 1, 2, -3]
        //output:
        //Buy at Day 1, Sell at Day 2
        //Index values input[0] - input[1]
        //This will give a max profit of 6
        public static void Method_1(int[] values)
        {
            int buyIndex = 0;
            int sellIndex = 0;
            int maxProfit = 0;
            for (int i = 0; i < values.Length - 1; ++i)
            {
                int buy = values[i];
                for (int j = i + 1; j < values.Length; ++j)
                {
                    int sell = values[j];
                    if (buy < sell && Math.Abs(buy - sell) > maxProfit)
                    {
                        buyIndex = i;
                        sellIndex = j;
                        maxProfit = Math.Abs(buy - sell);
                     //   Console.WriteLine(buyIndex+" - "+ sellIndex+" - "+maxProfit);
                    }
                }
            }
            Console.WriteLine("By at day {0}, sell at Day {1}", buyIndex + 1, sellIndex + 1);
            Console.WriteLine("Index values input[{0}] - input[{1}]", buyIndex, sellIndex);
            Console.WriteLine("This will give a max profit of {0}", maxProfit);
        }

        public static void Method_2(int[] values)
        {
            int maxDiff=0, maxPos=0;
            int minValue= values[0], minPos=0;
            Stack<int> buySell = new Stack<int>();
            for (int i = 0; i < values.Length; ++i)
            {
                int newMin = values[i] < minValue ? values[i] : minValue;
                if (newMin < minValue)
                {
                    minValue = newMin;
                    minPos = i;
                }
                int  diff = values[i] - minValue;
                int  newMax = diff > maxDiff ? diff : maxDiff;
                if (newMax > maxDiff)
                {
                    maxPos = i;
                    maxDiff = newMax;
                    buySell.Push(maxPos);
                    buySell.Push(minPos);
                }
            }
            minPos = buySell.Pop();
            maxPos = buySell.Pop();
            Console.WriteLine("By at day {0}, sell at Day {1}", minPos + 1, maxPos + 1);
            Console.WriteLine("Index values input[{0}] - input[{1}]", minPos, maxPos);
            Console.WriteLine("This will give a max profit of {0}", maxDiff);
        }
    }
}
