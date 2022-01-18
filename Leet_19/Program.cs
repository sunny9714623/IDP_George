using System;

namespace Leet_19
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = CreateList(new int[] { 1,2,3,4,5});
            ListNode ret = RemoveNthFromEnd(head, 2);
        }
        // 常规做法：第一次遍历获取长度，第二次遍历删除L-n+1出的节点。
        //public static ListNode RemoveNthFromEnd(ListNode head,int n)
        //{
        //    int i = 1, j = 1;
        //    ListNode ln1 = head, ln2 = head, ln2pre;
        //    if (head.next == null)
        //    {
        //        return null;
        //    }
        //    while (ln1.next != null)
        //    {
        //        ln1 = ln1.next;
        //        i++;
        //    }
        //    // 要删除的节点=length-n+1
        //    while (ln2 != null)
        //    {
        //        // 如果删除的是第一个节点。
        //        if (j == i - n + 1 && j == 1)
        //        {
        //            return ln2.next;
        //        }
        //        else
        //        {
        //            ln2pre = ln2;
        //            ln2 = ln2.next;
        //            j++;
        //            if (j == i - n + 1)
        //            {
        //                ln2pre.next = ln2.next;
        //                break;
        //            }
        //        }
        //    }
        //    return head;
        //}

        // 一次遍历：快慢节点。快的先行，慢的后行。快的领先n，当快的到达末尾时，慢的到达需要删除的节点。
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode first = head, second = head, secondeprew=null;
            for(int i = 0; i < n; i++)
            {
                // 快指针先行n步
                first = first.next;
            }
            if (first == null)
            {
                return head.next;
            }
            else
            {
                while (first != null)
                {
                    first = first.next;
                    secondeprew = second;
                    second = second.next;
                }
                secondeprew.next = second.next;
            }
            return head;
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
