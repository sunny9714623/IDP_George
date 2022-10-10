namespace Leet_0201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // 使用临时缓冲区
        //public static ListNode RemoveDuplicateNodes(ListNode head)
        //{
        //    HashSet<int> set = new HashSet<int>();
        //    if(head == null)
        //    {
        //        return head;
        //    }
        //    set.Add(head.val);
        //    ListNode pre = head;
        //    while (pre.next != null)
        //    {
        //        if (!set.Add(pre.next.val))
        //        {
        //            pre.next = pre.next.next;
        //        }
        //        else
        //        {
        //            pre = pre.next;
        //        }
        //    }
        //    pre.next = null;
        //    return head;
        //}

        // 使用双重循环
        public static ListNode RemoveDuplicateNodes(ListNode head)
        {
            ListNode p1 = head;
            while (p1 != null)
            {
                ListNode p2 = p1;
                while (p2.next != null)
                {
                    if(p2.next.val == p1.val)
                    {
                        p2.next = p2.next.next;
                    }
                    else
                        p2 = p2.next;
                }
                p1 = p1.next;
            }
            return head;
        }
    }
    public class ListNode
    {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
    }
}