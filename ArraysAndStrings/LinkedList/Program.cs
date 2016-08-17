using System;

namespace LinkedList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("RemoveDups. Remove duplicate from an unsorted linked list");
            Console.WriteLine("-> Method 1");
            MyList<int> listRemoveDups = GenerateMyList(100);
            listRemoveDups.AppenToTail(22);
            listRemoveDups.ShowList();
            RemoveDups<int>.Method_1(listRemoveDups);
            listRemoveDups.ShowList();
            listRemoveDups = GenerateMyList(100);
            listRemoveDups.ShowList();
            RemoveDups<int>.Method_1(listRemoveDups);
            listRemoveDups.ShowList();
            Console.WriteLine("############################################");
            Console.WriteLine("-> Method 2");
            listRemoveDups = GenerateMyList(100);
            listRemoveDups.AppenToTail(22);
            listRemoveDups.ShowList();
            RemoveDups<int>.Method_2(listRemoveDups);
            listRemoveDups.ShowList();
            listRemoveDups = GenerateMyList(100);
            listRemoveDups.ShowList();
            RemoveDups<int>.Method_2(listRemoveDups);
            listRemoveDups.ShowList();
            Console.WriteLine("############################################");
            Console.WriteLine("############################################");
            Console.WriteLine("Return Kth To Last");
            MyList<int> list = GenerateSequentialMyList(100);
            list.ShowList();
            Console.WriteLine("50 element from end in 100 element list " + ReturnKthToLast<int>.Method_1(list, 50)?.Data);
            Console.WriteLine("5 element from end in 100 element list  " + ReturnKthToLast<int>.Method_1(list, 5)?.Data);
            Console.WriteLine("500 element from end in 100 element list " + ReturnKthToLast<int>.Method_1(list, 500)?.Data);
            Console.WriteLine("############################################");
            Console.ReadLine();
        }

        private static MyList<int> GenerateSequentialMyList(int max)
        {
            MyList<int> retList = new MyList<int>(1);
            for (int i = 2; i < max; ++i)
            {
                retList.AppenToTail(i);
            }
            return retList;
        }

        private static MyList<int> GenerateMyList(int v)
        {
            MyList<int> retList = new MyList<int>();
            Random ran = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < v; ++i)
            {
                retList.AppenToTail(ran.Next(1, 10));
            }
            return retList;
        }
    }
}