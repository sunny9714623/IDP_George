using System.Collections.Concurrent;

namespace Leet_110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((obj) => IsBalanced(new TreeNode()));

        }

        public static void Test(Object obj)
        {
            Console.WriteLine(obj);
        }

        public static bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            else
            {
                return Math.Abs(Height(root.left)-Height(root.right)) <=1 && IsBalanced(root.left) && IsBalanced(root.right);
            }
        }

        /// <summary>
        /// 计算任意节点P的高度
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private static int Height(TreeNode node)
        {
            if(node == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(Height(node.left), Height(node.right)) + 1;
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}