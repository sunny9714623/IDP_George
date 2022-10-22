namespace Leet_116
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        /// <summary>
        /// 层次遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>

        public static Node Connect(Node root)
        {
            if (root == null) return root;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int n = queue.Count;
                for(int i = 0; i < n; i++)
                {
                    Node node = queue.Dequeue();
                    if (i < n - 1)
                    {
                        node.next = queue.Peek();
                    }
                    if(node.left!=null)
                        queue.Enqueue(node.left);
                    if(node.right!=null)
                        queue.Enqueue(node.right);
                }
            }
            return root;
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}