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
            Console.WriteLine("############################################");
            Console.WriteLine("Return midle node");
            list = GenerateSequentialMyList(100);
            list.ShowList();
            DeleteMiddleNode<int>.Method_1(list).ShowList();
            list = GenerateSequentialMyList(11);
            Console.WriteLine("############################################");
            list.ShowList();
            DeleteMiddleNode<int>.Method_1(list).ShowList();
            Console.WriteLine("############################################");
            Console.WriteLine("############################################");
            Console.WriteLine("Sum List");
            Console.WriteLine("Reverse order");
            MyList<int> list1 = new MyList<int>(7); list1.AppenToTail(1); list1.AppenToTail(6);
            MyList<int> list2 = new MyList<int>(5); list2.AppenToTail(9); list2.AppenToTail(2);
            SumLists.Method_ReverseOrder(list1, list2).ShowList();
            Console.WriteLine("############################################");
            Console.WriteLine("Foward order");
            list1 = new MyList<int>(6); list1.AppenToTail(1); list1.AppenToTail(7);
            list2 = new MyList<int>(2); list2.AppenToTail(9); list2.AppenToTail(5);
            SumLists.Method_FowardOrder(list1, list2).ShowList();
            Console.WriteLine("############################################");
            Console.WriteLine("############################################");
            Console.WriteLine("Reverse List");
            MyList<char> listChar = new MyList<char>('A');
            for (char i = 'B'; i <= 'Z'; ++i)
            {
                listChar.AppenToTail(i);
            }
            listChar.ShowList();
            ReverseList<char>.Method_1(listChar).ShowList();
            Console.WriteLine("############################################");
            Console.WriteLine("############################################");
            Console.WriteLine("Remove kth element from last");
            listChar = new MyList<char>('A'); listChar.AppenToTail('B'); listChar.AppenToTail('C'); listChar.AppenToTail('D'); listChar.AppenToTail('E');
            listChar.ShowList();
            RemoveKthElementFromLast<char>.Method_1(listChar,3).ShowList();
            Console.WriteLine("############################################");
            Console.WriteLine("############################################");
            Console.WriteLine("Detect circular list");
            ListNode<char> nodeA = new ListNode<char>('A');
            ListNode<char> nodeB = new ListNode<char>('B');
            ListNode<char> nodeC = new ListNode<char>('C');
            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            nodeC.Next = nodeA;
            MyList<char> badList = new MyList<char>(nodeA);
            Console.WriteLine("A -> B -> C -> A (unable to use showList)");
            Console.WriteLine("############################################");
            Console.WriteLine(DetectCircleList<char>.Method_1(badList));
            Console.WriteLine("############################################");
            listChar.ShowList();
            Console.WriteLine(DetectCircleList<char>.Method_1(listChar));
            Console.ReadLine();
        }

        private static MyList<int> GenerateSequentialMyList(int max)
        {
            MyList<int> retList = new MyList<int>(1);
            for (int i = 2; i <= max; ++i)
            {
                retList.AppenToTail(i);
            }
            return retList;
        }

        private static MyList<int> GenerateMyList(int max)
        {
            MyList<int> retList = new MyList<int>();
            Random ran = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i <= max; ++i)
            {
                retList.AppenToTail(ran.Next(1, 10));
            }
            return retList;
        }
    }
}