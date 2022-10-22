namespace Leet_236
{
    internal class Program
    {
        public static TreeNode ans;
        static void Main(string[] args)
        {

        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            DFS(root, p, q);
            return ans;
        }

        public static bool DFS(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || ans != null)
            {
                return false;
            }
            bool cur = p.val == root.val || q.val == root.val;
            bool left = DFS(root.left, p, q);
            bool right = DFS(root.right, p, q);
            if((left && right) || (cur && (left || right)))
            {
                ans = root;
            }
            return cur || left || right;
        }

        public static TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode ans = root;
            while (true)
            {
                if(p.val< ans.val && q.val < ans.val)
                {
                    ans = ans.left;
                }
                else if(p.val>ans.val && q.val > ans.val)
                {
                    ans = ans.right;
                }
                else
                {
                    return ans;
                }
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