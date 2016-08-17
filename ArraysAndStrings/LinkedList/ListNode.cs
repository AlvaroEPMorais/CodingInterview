namespace LinkedList
{
    public class ListNode<T>
    {
        public ListNode<T> Next = null;
        public T Data;

        public ListNode(T data)
        {
            Data = data;
        }

        public ListNode()
        {
            Data = default(T);
            Next = null;
        }
    }
}