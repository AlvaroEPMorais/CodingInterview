using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class ReverseList<T>
    {
        public static MyList<T> Method_1(MyList<T> list)
        {
            if (list == null)
            {
                return null;
            }
            ListNode<T> node = list.Head;
            MyList<T> ret = new MyList<T>(node.Data);
            node = node.Next;
            while (node!= null)
            {
                ListNode<T> newNode = new ListNode<T>(node.Data) {Next = ret.Head};
                ret.Head = newNode;
                node = node.Next;
            }
            return ret;
        }
    }
}
