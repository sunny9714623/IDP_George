using System;
// 给你一个链表的头节点 head ，旋转链表，将链表每个节点向右移动 k 个位置。
namespace Leet_61
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ret = CreateList(new int[] { 1,2,3,4,5});
            ListNode result = RotateRight(ret.next, 3);
        }
        /// <summary>
        /// 做法,从后往前数第k%Listnode.length作为头结点，然后把首节点连接在尾部就可以
        /// 空间复杂度高
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        //public static ListNode RotateRight(ListNode head, int k)
        //{
        //    if (head == null || head.next == null)
        //    {
        //        return head == null ? null : head;
        //    }
        //    int count = 0;
        //    ListNode lNode1 = head, lNode2 = head, lNode3 = lNode2;
        //    while (lNode1 != null)
        //    {
        //        count++;
        //        lNode1 = lNode1.next;
        //    }
        //    int m = k % count;
        //    if (m == 0)
        //    {
        //        return head;
        //    }
        //    // count-m 从正数
        //    while (count - m - 1 > 0 && lNode2 != null)
        //    {
        //        lNode2 = lNode2.next;
        //        m++;
        //    }
        //    ListNode newHead = lNode2.next, newHeadret = newHead;
        //    lNode2.next = null;
        //    while (newHeadret.next != null)
        //    {
        //        newHeadret = newHeadret.next;
        //    }
        //    newHeadret.next = lNode3;
        //    return newHead;
        //}

        /// 双指针算法，第一个指针先走K个节点，当第一个指针到达尾部时，后指针后面有k个节点，
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
            {
                return head == null ? null : head;
            }
            int count = 0;
            ListNode lNode1 = head, lNode2 = head, lNode3 = lNode2;
            while (lNode1 != null)
            {
                count++;
                lNode1 = lNode1.next;
            }
            int m = k % count;
            if (m == 0)
            {
                return head;
            }
            while (m-- > 0)
            {
                lNode2 = lNode2.next;
            }
            while(lNode2.next != null)
            {
                lNode2 = lNode2.next;
                lNode3 = lNode3.next;
            }
            lNode2.next = head;
            ListNode ret = lNode3.next;
            lNode3.next = null;
            return ret;
        }

        public static ListNode CreateList(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }
            ListNode head = new ListNode(0), Lnext = head;
            for(int i = 0; i < nums.Length; i++)
            {
                ListNode curNode = new ListNode(nums[i]);
                Lnext.next = curNode;
                Lnext = curNode;
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
