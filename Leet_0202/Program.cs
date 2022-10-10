namespace Leet_0202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int KthToLast(ListNode head, int k)
        {
            ListNode p2 = head,p1 = head;
            for(int i = 0; i < k; i++)
            {
                p2 = p2.next;
            }
            while (p2 != null)
            {
                p2 = p2.next;
                p1 = p1.next;
            }
            return p1.val;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}