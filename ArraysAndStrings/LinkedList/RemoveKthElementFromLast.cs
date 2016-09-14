using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class RemoveKthElementFromLast<T>
    {
        public static MyList<T> Method_1(MyList<T> list, int k)
        {
            int num = k;
            ListNode<T> runner = list.Head;
            while (num > 0 && runner != null)
            {
                runner = runner.Next;
                num--;
            }
            if (runner == null && num > 0)
            {
                return list;
            }
            ListNode<T> node = list.Head;
            while (runner?.Next != null)
            {
                node = node.Next;
                runner = runner.Next;
            }
            node.Next = node.Next.Next;
            return list;
        }
    }
}
