using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class ReturnKthToLast<T>
    {
       
        public static ListNode<T> Method_1(MyList<T> list, int k)
        {
            ListNode<T> runner = list.Head;
            int num = k;
           
            while (num > 0 && runner != null)
            {
                runner = runner.Next;
                --num;
            }
            if (runner == null && num > 0)
            {
                return null;
            }
            ListNode<T> node = list.Head;
            while (runner?.Next != null)
            {
                node = node.Next;
                runner = runner.Next;
            }
            return node;
        }
    }
}
