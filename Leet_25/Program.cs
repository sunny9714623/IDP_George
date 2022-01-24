using System;
using System.Collections;
using System.Collections.Generic;

namespace Leet_25
{
    class Program
    {
        /// <summary>
        /// 给你一个链表，每 k 个节点一组进行翻转，请你返回翻转后的链表。
        /// k 是一个正整数，它的值小于或等于链表的长度。
        /// 如果节点总数不是 k 的整数倍，那么请将最后剩余的节点保持原有顺序。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ListNode test = CreateList(new int[] { 1,2,3,4,5});
            ListNode rt = ReverseKGroup(test, 3);
        }
        //public static Stack<ListNode> s = new Stack<ListNode>();
        ///// <summary>
        ///// 使用栈和递归解决。但是不满足进阶：使用常数额外空间的算法。
        ///// </summary>
        ///// <param name="head"></param>
        ///// <param name="k"></param>
        ///// <returns></returns>
        //public static ListNode ReverseKGroup(ListNode head,int k)
        //{
        //    ListNode h = head;
        //    ListNode hd = new ListNode(0),hd2;
        //    hd.next = head;
        //    hd2 = hd;
        //    if (head == null) { return null; }
        //    while (h != null && s.Count!=k)
        //    {
        //        s.Push(h);
        //        h = h.next;
        //    }
        //    // 如果不足K个，原序返回
        //    if (s.Count < k)
        //    {
        //        return head;
        //    }
        //    // 否则，逆序链接新的链表
        //    else
        //    {
        //        while (s.Count != 0)
        //        {
        //            hd.next = s.Pop();
        //            hd = hd.next;
        //        }
        //    }
        //    hd.next = ReverseKGroup(h, k);
        //    return hd2.next;
        //}

        /// <summary>
        /// 借鉴评论区大神的写法。很牛逼。
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ListNode ReverseKGroup(ListNode head,int k)
        {
            ListNode dummy = new ListNode(0),pre,curr,next;
            pre = dummy;curr = head;dummy.next = head;
            int number = 0;// 统计链表的长度
            while (head != null)
            {
                number++;
                head = head.next;
            }
            for(int i = 0; i < number / k; i++)
            {
                for(int j = 0; j < k - 1; j++)
                {
                    // curr没变，依次将curr后面的节点移到curr的前面。如：1，2，3，-> 2,1,3->3,2,1
                    next = curr.next;
                    curr.next = next.next;
                    next.next = pre.next;
                    pre.next = next;
                }
                pre = curr;
                curr = pre.next;
            }
            return dummy.next;
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
