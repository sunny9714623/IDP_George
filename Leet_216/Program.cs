namespace Leet_216
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CombinationSum3(4, 10);
            var result = program.ans;
        }
        IList<IList<int>> ans = new List<IList<int>>();
        IList<int> temp = new List<int>();
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            DFS(k, n, 1);
            return ans;
        }

        /// <summary>
        /// 和为n,个数为k，当前选择的数为cur
        /// </summary>
        /// <param name="k"></param>
        /// <param name="n"></param>
        /// <param name="cur"></param>
        //public void DFS(int k,int n,int cur)
        //{
        //    if(temp.Count == k && n == 0)
        //    {
        //        ans.Add(new List<int>(temp));
        //        return;
        //    }
        //    if (cur > 9 || cur > n || temp.Count > k)
        //    {
        //        return;
        //    }
        //    temp.Add(cur);
        //    DFS(k, n - cur, cur + 1);
        //    temp.RemoveAt(temp.Count - 1);
        //    DFS(k, n, cur + 1);
        //}

        ///当cur可以重复
        public void DFS(int k, int n, int cur)
        {
            if (temp.Count == k && n == 0)
            {
                ans.Add(new List<int>(temp));
                return;
            }
            if (cur > 9 || cur > n || temp.Count > k)
            {
                return;
            }
            //temp.Add(cur);
            //DFS(k, n - cur, cur + 1);
            //temp.RemoveAt(temp.Count - 1);
            //DFS(k, n, cur + 1);

            //可以允许cur重复，选择cur，不选择cur
            temp.Add(cur);
            DFS(k, n - cur, cur);
            temp.RemoveAt(temp.Count - 1);
            DFS(k, n, cur + 1);
        }
    }
}