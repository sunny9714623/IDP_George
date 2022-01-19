using System;

namespace Leet_23
{
    /// <summary>
    /// 给你一个链表数组，每个链表都已经按升序排列。
    /// 请你将所有链表合并到一个升序链表中，返回合并后的链表。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = CreateList(new int[] { 1, 4, 5 });
            ListNode l2 = CreateList(new int[] { 1, 3, 4 });
            ListNode l3 = CreateList(new int[] { 2, 6 });
            ListNode l4 = CreateList(new int[] { });
            ListNode[] test = new ListNode[] {l1,l2,l3 };
            ListNode ret = MergeKLists(test);
        }
        /// <summary>
        /// 递归方法，感觉效率不太高，代码少
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        //public static ListNode MergeKLists(ListNode[] lists)
        //{
        //    int min = int.MaxValue;
        //    int number = 0;
        //    for(int i = 0;i<lists.Length;i++)
        //    {
        //        ListNode ln = lists[i];
        //        if (ln?.val < min)
        //        {
        //            number = i;
        //            min = ln.val;
        //        }
        //    }
        //    if (min == int.MaxValue)
        //    {
        //        // 如果都遍历完了
        //        return null;
        //    }
        //    ListNode list = new ListNode(lists[number].val);
        //    /// 如果为null还是为null
        //    lists[number] = lists[number]?.next;
        //    list.next = MergeKLists(lists);
        //    return list;
        //}

        ///分治法太快了。很好理解，就是每次合并两路
        public static ListNode MergeKLists(ListNode[] lists)
        {
            return Merge(lists, 0, lists.Length-1);
        }
        public static ListNode Merge(ListNode[] lists,int l,int r)
        {
            if (l == r)
            {
                return lists[l];
            }
            if (l > r)
            {
                return null;
            }
            // 右移一位=除以2
            int mid = (l + r) >> 1;
            return MergeTwoList(Merge(lists, l, mid), Merge(lists, mid+1, r));
        }
        
        public static ListNode MergeTwoList(ListNode l1,ListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return l1 == null ? l2 : l1;
            }
            // 设置一个头结点
            ListNode head = new ListNode(0);
            ListNode pre = head;// pre 当前节点的前一个
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    pre.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    pre.next = l2;
                    l2 = l2.next;
                }
                pre = pre.next;
            }
            pre.next = l1 == null ? l2 : l1;
            return head.next;
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
