using System.Collections.Generic;

namespace LinkedList
{
    public static class RemoveDups<T>
    {
        public static MyList<T> Method_1(MyList<T> list)
        {
            ListNode<T> node = list.Head;
            HashSet<T> mySet = new HashSet<T>();
            mySet.Add(node.Data);
            while (node?.Next != null)
            {
                if (!mySet.Add(node.Next.Data))
                {
                    node.Next = node.Next.Next;
                }
                else
                {
                    node = node.Next;
                }
            }
            return list;
        }

        public static MyList<T> Method_2(MyList<T> list)
        {
            ListNode<T> nodeAct = list.Head;
            while (nodeAct?.Next != null)
            {
                ListNode<T> runner = nodeAct;
                while (runner.Next != null)
                {
                    if (nodeAct.Data.Equals(runner.Next.Data))
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                nodeAct = nodeAct.Next;
            }
            return list;
        }
    }
}