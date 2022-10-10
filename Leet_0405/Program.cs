namespace Leet_0405
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // 一种思路：
        //public bool IsValidBST(TreeNode root) => IsValidBST(root, long.MinValue, long.MaxValue);
        //public bool IsValidBST(TreeNode root,long min,long max)
        //{
        //    if (root == null) return true;
        //    if (root.val <= min || root.val >= max) return false;
        //    return IsValidBST(root.left, min, (long)root.val) && IsValidBST(root.right, (long)root.val, max);
        //}

        // 另外一种思路,这种思路有问题，对于右边字树子节点小于爷爷节点时判断不出来。
        //public static bool IsValidBST(TreeNode root)
        //{
        //    if (root == null) return true;
        //    if (root.left != null && root.val <= root.left.val) return false;
        //    if (root.right != null && root.val >= root.right.val) return false;
        //    if (root.left == null && root.right == null) return true;
        //    return IsValidBST(root.left) && IsValidBST(root.right);
        //}


        // 二叉搜索树的中序遍历递增
        // 需要定义一个全局的前缀节点
        static TreeNode pre = null;
        public static bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            if (!IsValidBST(root.left))
            {
                return false;
            }
            if (pre != null && pre.val >= root.val) return false;
            pre = root;
            if (!IsValidBST(root.right))
            {
                return false;
            }
            return true;
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