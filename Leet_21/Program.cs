using System;

namespace Leet_21
{
    /// <summary>
    /// 将两个升序链表合并为一个新的 升序 链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = CreateList(new int[] { 1,2,4});
            ListNode l2 = CreateList(new int[] { 1,3,4});
            ListNode res = MergeTwoLists(l1,l2);
        }
        /// <summary>
        /// 递归解法。 
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static ListNode MergeTwoLists(ListNode list1,ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            var ans = list1.val < list2.val ? list1 : list2;
            ans.next = MergeTwoLists(ans.next, list1.val < list2.val ? list2 : list1);
            return ans;
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
