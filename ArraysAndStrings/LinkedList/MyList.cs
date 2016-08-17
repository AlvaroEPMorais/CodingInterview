using System;

namespace LinkedList
{
    public class MyList<T>
    {
        public ListNode<T> Head = null;

        public MyList()
        {
            Head = new ListNode<T> { Next = null };
        }

        public MyList(ListNode<T> head)
        {
            Head = head;
            Head.Next = null;
        }

        public MyList(T data)
        {
            ListNode<T> node = new ListNode<T>(data)
            {
                Next = null
            };
            Head = node;
        }

        public void AppenToTail(T data)
        {
            ListNode<T> end = new ListNode<T>(data);
            ListNode<T> n = this.Head;
            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = end;
        }

        public ListNode<T> DeleteNode(ListNode<T> head, T data)
        {
            ListNode<T> n = head;
            if (n.Data.Equals(data))
            {
                //OFF with its head
                return head.Next;
            }
            while (n.Next != null)
            {
                if (n.Next.Data.Equals(data))
                {
                    n.Next = n.Next.Next;
                    return head;
                }
                n = n.Next;
            }
            return head;
        }

        public void ShowList()
        {
            ListNode<T> n = this.Head;

            while (n != null)
            {
                Console.Write(n.Data + " -> ");

                n = n.Next;
            }
            Console.WriteLine("end\n####################\n");
        }
    }
}