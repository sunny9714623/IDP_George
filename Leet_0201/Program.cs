using System.Collections;

namespace Leet_0201
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(4);
            ListNode node3 = new ListNode(5);
            ListNode node4 = new ListNode(1);
            ListNode node5 = new ListNode(3);
            ListNode node6 = new ListNode(4);
            ListNode node7 = new ListNode(2);
            ListNode node8 = new ListNode(6);
            node1.next = node2;
            node2.next = node3;
            node4.next = node5;
            node5.next = node6;
            node7.next = node8;
            var head = MergeKList(new ListNode[] { node1, node4, node7 });
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

        public static ListNode MergeKList(ListNode[] lists)
        {
            //PriorityQueue<ListNode, ListNode> priorityQueue = new PriorityQueue<ListNode, ListNode>(10, new MyCompare());

            PriorityQueue<ListNode, int> priorityQueue = new PriorityQueue<ListNode, int>(lists.Length, new MyCompare1());
            if (lists == null)
            {
                return null;
            }
            ListNode dummy = new ListNode(-1);
            ListNode p = dummy;
            foreach(ListNode node in lists)
            {
                if (node != null)
                {
                    priorityQueue.Enqueue(node, node.val);
                }
            }

            while (priorityQueue.Count != 0)
            {
                var node = priorityQueue.Dequeue();
                p.next = node;
                if (node.next != null)
                {
                    priorityQueue.Enqueue(node.next, node.next.val);
                }
                p = p.next;
            }
            return dummy.next;
        }
    }

     public class MyCompare : IComparer<ListNode>
    {
        public int Compare(ListNode? x, ListNode? y)
        {
            return (x?.val - y?.val).Value;
        }
    }

    public class MyCompare1 : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }
    public class ListNode
    {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
    }

}