namespace Leet_0208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // hash表存储
        //public static ListNode DetectCycle(ListNode head)
        //{
        //    HashSet<ListNode> cycle = new HashSet<ListNode>();
        //    while (head != null)
        //    {
        //        if(!cycle.Contains(head)) cycle.Add(head);
        //        else
        //        {
        //            return head;
        //        }
        //        head = head.next;
        //    }
        //    return head;
        //}

        // 快慢指针,第一个指针走2n，第二个指针走n
        // 有a+(n+1)b+nc=2(a+b)⟹a=c+(n−1)(b+c)，因此当相遇后，最终，它们会在入环点相遇
        public static ListNode DetectCycle(ListNode head)
        {
            if(head == null)
            {
                return head;
            }
            ListNode first = head, second = head;
            while(second != null)
            {
                first=first.next;
                if (second.next != null)
                {
                    second = second.next.next;
                }
                else
                {
                    return null;
                }
                if (first == second)
                {
                    ListNode ptr = head;
                    while(ptr != first)
                    {
                        ptr = ptr.next;
                        first = first.next;
                    }
                    return ptr;
                }
            }
            return null;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}