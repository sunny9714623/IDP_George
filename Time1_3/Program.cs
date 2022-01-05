 using System;
using static System.Console;
using System.Linq;

namespace Time1_3
{
    /// <summary>
    /// 给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。
    /// 请你将两个数相加，并以相同形式返回一个表示和的链表。
    /// 你可以假设除了数字 0 之外，这两个数都不会以 0 开头。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 9,9,9,9,9,9,9 };
            ListNode l1 = CreateList(nums1);
            int[] nums2 = new int[] { 9, 9, 9,9 };
            ListNode l2 = CreateList(nums2);
            ListNode ret = AddTwoNumbers(l1, l2);
        }
        public static ListNode CreateList(int[] arr)
        {
            ListNode head = null;
            ListNode list = head;
            foreach(var item in arr)
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

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l3 = null;
            ListNode l3Back = null;
            int add = 0;
            while (l1!= null || l2!= null || add!=0)
            {
                add = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + add;
                if (l3 == null)
                {
                    l3 = new ListNode(add % 10);
                    add /= 10;
                    l3.next = null;
                    l3Back = l3;
                }
                else
                {
                    l3Back.next = new ListNode(add % 10);
                    add /= 10;
                    l3Back = l3Back.next;
                }
                l1 = l1 ?.next; // l1 = l1==null? l1:l1.next;
                l2 = l2 ?.next;
            }
            return l3;
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
