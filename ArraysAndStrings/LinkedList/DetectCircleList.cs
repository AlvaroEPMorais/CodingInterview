using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class DetectCircleList<T>
    {
        public static String Method_1(MyList<T> list)
        {
            ListNode<T> node = list.Head;
            ListNode<T> runner = list.Head.Next;        
            while (runner != null)
            {
                if (runner.Next == node)
                {
                    return runner.Data.ToString();
                }
                runner = runner.Next;
            }
            return "false";
        }
    }
}
