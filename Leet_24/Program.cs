using System;

namespace Leet_24
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = CreateList(new int[] { 1,2,3,4 });
            ListNode ret = SwapPairs(l1);
        }

        /// <summary>
        ///  迭代
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        //public static ListNode SwapPairs(ListNode head)
        //{
        //    ListNode node = new ListNode(0);
        //    node.next = head;
        //    // pre 交换的两个节点的前一个节点
        //    ListNode pre = node;
        //    if (head == null)
        //    {
        //        return null;
        //    }
        //    if (head.next == null)
        //    {
        //        return head;
        //    }
        //    while (head != null)
        //    {
        //        ListNode left_node = head;
        //        /// 如果节点只剩下一个，结束循环
        //        if (head.next == null)
        //        {
        //            break;
        //        }
        //        head = head.next;
        //        ListNode right_node = head;
        //        head = head.next;
        //        // 交换操作
        //        left_node.next = right_node.next;
        //        right_node.next = left_node;
        //        pre.next = right_node;
        //        pre = left_node;
        //    }
        //    return node.next;
        //}

        // 递归
        public static ListNode SwapPairs(ListNode head)
        {
            // 如果当前节点不满足交换条件
            if (head == null || head.next == null)
            {
                return head;
            }
            // 第二个节点newHead,新链表的头结点
            ListNode newHead = head.next;
            head.next = SwapPairs(newHead.next);
            newHead.next = head;
            return newHead;
        }
        public static ListNode CreateList(int[] arr)
        {
            ListNode head = null;
            ListNode list = head;
            foreach (var item in arr)
            {
                ListNode ln = new ListNode(item);
                if (head == null)
                {
                    head = ln;
                    list = head;
                }
                else
                {
                    list.next = ln;
                    list = list.next;
                }
            }
            return head;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0,ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
