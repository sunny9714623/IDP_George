namespace Leet_113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode51= new TreeNode(5);
            TreeNode treeNode41 = new TreeNode(4);
            TreeNode treeNode8 = new TreeNode(8);
            TreeNode treeNode11 = new TreeNode(11);
            TreeNode treeNode13 = new TreeNode(13);
            TreeNode treeNode42 = new TreeNode(4);
            TreeNode treeNode7 = new TreeNode(7);
            TreeNode treeNode2 = new TreeNode(2);
            TreeNode treeNode52 = new TreeNode(5);
            TreeNode treeNode1 = new TreeNode(1);
            treeNode51.left = treeNode41;
            treeNode51.right = treeNode8;
            treeNode41.left = treeNode11;
            treeNode11.left = treeNode7;
            treeNode11.right = treeNode2;
            treeNode8.left = treeNode13;
            treeNode8.right = treeNode42;
            treeNode42.left = treeNode52;
            treeNode42.right = treeNode1;
            PathSum(treeNode51, 22);
        }
        static IList<IList<int>> ans = new List<IList<int>>();
        static IList<int> temp = new List<int>();
        public static IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            DFS(root, targetSum);
            return ans;
        }

        /// <summary>
        /// 没看清楚题目，题目要求的是从根节点到叶节点
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        //public static void DFS(TreeNode root,int target)
        //{
        //    if (target == 0)
        //    {
        //        ans.Add(new List<int>(temp));
        //        return;
        //    }
        //    if (root == null)
        //    {
        //        return;
        //    }
        //    temp.Add(root.val);
        //    DFS(root.left, target - root.val);
        //    DFS(root.right, target - root.val);
        //    temp.RemoveAt(temp.Count - 1);
        //    DFS(root.left, target);
        //    DFS(root.right, target);
        //}

        public static void DFS(TreeNode root, int target)
        {
            if (root == null) return;
            temp.Add(root.val);
            target -= root.val;
            if(root.left == null && root.right == null && target == 0)
            {
                ans.Add(new List<int>(temp));
                // 这里不能要return，否则的话没有末尾的回溯操作。
            }
            DFS(root.left, target);
            DFS(root.right, target);
            temp.RemoveAt(temp.Count - 1);
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