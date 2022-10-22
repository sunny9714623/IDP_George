namespace Leet_222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode1 = new TreeNode(1);
            TreeNode treeNode2 = new TreeNode(2);
            TreeNode treeNode3 = new TreeNode(3);
            TreeNode treeNode4 = new TreeNode(4);
            TreeNode treeNode5 = new TreeNode(5);
            TreeNode treeNode6 = new TreeNode(6);
            treeNode1.left = treeNode2;
            treeNode1.right = treeNode3;
            treeNode2.left = treeNode4;
            treeNode2.right = treeNode5;
            treeNode3.left = treeNode6;
            int ret = CountNodes(treeNode1);
        }

        /// <summary>
        /// 回家等通知
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>

        //public static int CountNodes(TreeNode root)
        //{
        //    if (root == null) return 0;
        //    int count1 = CountNodes(root.left);
        //    int count2 = CountNodes(root.right);
        //    return count1 + count2 + 1;
        //}

        public static int CountNodes(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);
            if(leftHeight == rightHeight) //说明左子树一定是满二叉树，满二叉树节点的性质，
            {
                return CountNodes(root.right) + (1 << leftHeight);
            }
            else
            {
                return CountNodes(root.left) + (1 << rightHeight);
            }
        }

        private static int GetHeight(TreeNode root)
        {
            int count = 0;
            while (root!= null)
            {
                count++;
                root = root.left;
            }
            return count;
        }
    }
}