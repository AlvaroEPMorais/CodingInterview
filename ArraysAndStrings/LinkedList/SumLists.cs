using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class SumLists
    {
        public static MyList<int> Method_ReverseOrder(MyList<int> list1, MyList<int> list2)
        {
            int num1 = 0, num2 = 0, mul = 1;
            ListNode<int> node = list1.Head;
            while (node != null)
            {
                num1 = num1 + (node.Data * mul);
                mul = mul * 10;
                node = node.Next;
            }
            node = list2.Head;
            mul = 1;
            while (node != null)
            {
                num2 = num2 + (node.Data * mul);
                mul = mul * 10;
                node = node.Next;
            }
            int sum = num1 + num2;
            MyList<int> retList = new MyList<int>(sum % 10);
            sum = sum / 10;
            while (sum > 0)
            {
                retList.AppenToTail(sum % 10);
                sum = sum / 10;
            }
            return retList;
        }

        public static MyList<int> Method_FowardOrder(MyList<int> list1, MyList<int> list2)
        {
            int num1 = 0, num2 = 0;
            ListNode<int> node = list1.Head;
            while (node != null)
            {
                num1 = (num1 > 0 ? num1 * 10 : num1) + node.Data;

                node = node.Next;
            }
            node = list2.Head;

            while (node != null)
            {
                num2 = (num2 > 0 ? num2 * 10 : num2) + node.Data;

                node = node.Next;
            }
            int sum = num1 + num2;
            MyList<int> retList = new MyList<int>(sum % 10);
            sum = sum / 10;
            while (sum > 0)
            {
                ListNode<int> nodeAux = new ListNode<int>(sum % 10);
                nodeAux.Next = retList.Head;
                retList.Head = nodeAux;
                sum = sum / 10;
            }
            return retList;
        }
    }
}
