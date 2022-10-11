using System.Text;

namespace Leet_0410
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        //public bool CheckSubTree(TreeNode t1, TreeNode t2)
        //{
        //    // 这里只检查引用有问题。
        //    //if (t1 == t2 || t1?.val == t2?.val)
        //    //{
        //    //    return true;
        //    //}
        //    if (t1 == null || t2 == null)
        //    {
        //        return false;
        //    }
        //    if(t1.val==t2.val) return CheckSubTree(t1.left,t2.left)&&CheckSubTree(t1.right,t2.right);
        //    else
        //    {
        //        return CheckSubTree(t1.left, t2) || CheckSubTree(t1.right, t2);
        //    }
        //}

        /// <summary>
        /// 使用遍历得到的字符串应该是子串
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public bool CheckSubTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == t2)
            {
                return true;
            }
            if (t1 == null || t2 == null) return false;
            FronttOrder(t1, s1);
            FronttOrder(t2, s2);
            return s1.ToString().Contains(s2.ToString());
        }
        StringBuilder s1 = new StringBuilder();
        StringBuilder s2 = new StringBuilder();
        /// <summary>
        /// 前序递归遍历
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="s"></param>
        private static void FronttOrder(TreeNode tree,StringBuilder s)
        {
            if (tree == null) return;
            s.Append(tree.val);
            FronttOrder(tree.left, s);
            FronttOrder(tree.right, s);
        }
        private static void MidOrder(TreeNode tree, StringBuilder s)
        {
            if (tree == null) return;
            MidOrder(tree.left, s);
            s.Append(tree.val);
            MidOrder(tree.right, s);
        }

        private static void BackOrder(TreeNode tree, StringBuilder s)
        {
            if (tree == null) return;
            BackOrder(tree.left, s);
            BackOrder(tree.right, s);
            s.Append(tree.val);
        }

        /// <summary>
        /// 树的非递归前序遍历，使用栈
        /// </summary>
        /// <param name="tree"></param>
        private void FronttOrder1(TreeNode tree)
        {
            if (tree == null) return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(tree);
            while (stack.Count != 0)
            {
                TreeNode node = stack.Pop();
                if (node != null)
                {
                    s1.Append(node.val);
                    stack.Push(node.right);
                    stack.Push(node.left); //保证左子树先出栈
                }
            }
        }

        /// <summary>
        /// 后序遍历非递归
        /// </summary>
        /// <param name="tree"></param>
        private void backOrder1(TreeNode tree)
        {
            if (tree == null) return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(tree);
            while (stack.Count != 0)
            {
                TreeNode node = stack.Pop();
                if (node != null)
                {
                    s1.Append(node.val);
                    stack.Push(node.left);
                    stack.Push(node.right); //保证右子树先出栈
                }
            }
            s1.ToString().Reverse(); // 最后将得到的数组逆序输出即可。因为原来的顺序是根 - 右 - 左，倒叙后才是真正的后续遍历结果
        }

        /// <summary>
        /// 中序非递归遍历
        /// </summary>
        /// <param name="tree"></param>
        private void MidOrder1(TreeNode tree)
        {
            if (tree == null) return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = tree;
            while(cur != null || stack.Count != 0) //当前访问的节点不为空且栈不空的时候
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                } //当cur 为nul，即到底了
                TreeNode node = stack.Pop();
                s1.Append(node.val);
                cur = node.right;
            }
        }
    }
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
}