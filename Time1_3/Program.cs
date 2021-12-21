using System;
using static System.Console;
using System.Linq;

namespace Time1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 9, 9, 9,9,9,9,9 };
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
            while (l1!= null && l2!= null && add !=0)
            {
                int val = l1.val + l2.val + add;
                if (val > 9)
                {
                    add = 1;
                }
                else
                {
                    add = 0;
                }
                if (l3 == null)
                {
                    l3 = new ListNode();
                    l3.val = val % 10;
                    l3.next = null;
                    l3Back = l3;
                }
                else
                {
                    l3Back.next = new ListNode(val % 10);
                    l3Back = l3Back.next;
                }
                l1 = l1.next;
                l2 = l2.next;
                if (l2 == null)
                {
                    l2.val = 0;
                }
            }
            if (l1 == null)
            {
                l3Back.next = l2;
            }
            else
            {
                l3Back.next = l1;
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
