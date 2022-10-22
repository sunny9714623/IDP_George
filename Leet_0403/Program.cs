namespace Leet_0403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(char.ConvertFromUtf32('A'+1));
        }

        /// <summary>
        /// 用到树的层次遍历,这里需要用到两个变量记录树的层数
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public ListNode[] ListOfDepth(TreeNode tree)
        {
            List<ListNode> ret = new List<ListNode>();
            if (tree == null) return ret.ToArray();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(tree);
            int cur = 1, next = 0;
            var head = new ListNode(0);
            var node = head; 
            while (queue.Count != 0)
            {
                var curNode = queue.Dequeue();
                if(curNode.left != null)
                {
                    next++;
                    queue.Enqueue(curNode.left);
                }
                if (curNode.right != null)
                {
                    next++;
                    queue.Enqueue(curNode.right);
                }
                node.next = new ListNode(curNode.val);
                node = node.next;

                if (--cur == 0)
                {
                    ret.Add(head.next);
                    cur = next;
                    next = 0;
                    head = new ListNode(0);
                    node = head;
                }
            }
            return ret.ToArray();
        }


    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}