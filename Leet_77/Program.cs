namespace Leet_77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Combine(4, 3);
        }
        static IList<int> temp = new List<int>();
        static IList<IList<int>> ans = new List<IList<int>>();
        public static IList<IList<int>> Combine(int n, int k)
        {
            DFS(1, n, k);
            return ans;
        }

        public static void DFS(int cur, int n ,int k)
        {
            //if (cur > n + 1)
            //{
            //    return;
            //}
            // 减枝还可以这样减
            if(temp.Count + (n-cur+1) < k)
            {
                return;
            }
            if (temp.Count == k)
            {
                ans.Add(new List<int>(temp));
                return;
            }
            temp.Add(cur);
            DFS(cur + 1, n, k);
            temp.RemoveAt(temp.Count - 1);
            DFS(cur + 1, n, k);
        }
    }
}