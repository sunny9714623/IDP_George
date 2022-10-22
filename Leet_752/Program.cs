namespace Leet_752
{
    internal class Program
    {
        static ISet<string> dead = new HashSet<string>();
        static ISet<string> visited = new HashSet<string>();
        static void Main(string[] args)
        {
            string[] deadends = new string[] { "5557", "5553", "5575", "5535", "5755", "5355", "7555", "3555", "6655", "6455", "4655", "4455", "5665", "5445", "5645", "5465", "5566", "5544", "5564", "5546", "6565", "4545", "6545", "4565", "5656", "5454", "5654", "5456", "6556", "4554", "4556", "6554" };
            string target = "5555";
            int resut = OpenLock(deadends,target);
        }

        public static int OpenLock(string[] deadends, string target)
        {
            foreach (string deadend in deadends)
            {
                dead.Add(deadend);
                //visited.Add(deadend);
            }
            return BFS(deadends, target);
        }

        /// <summary>
        /// 单向BFS
        /// </summary>
        /// <param name="deadends"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        //private static int BFS(string[] deadends,string target)
        //{
        //    Queue<string> queue = new Queue<string>();
        //    int step = 0;
        //    queue.Enqueue("0000");
        //    visited.Add("0000");
        //    while (queue.Count != 0)
        //    {
        //        int n = queue.Count;
        //        for(int i = 0; i < n; i++)
        //        {
        //            string cur = queue.Dequeue();
        //            if (cur.Equals(target)) return step;
        //            if (dead.Contains(cur)) continue;
        //            for (int j = 0; j < 4; j++)
        //            {
        //                string up = Up(cur, j);
        //                if (!visited.Contains(up))
        //                {
        //                    queue.Enqueue(up);
        //                    visited.Add(up);
        //                }
        //                string down = Down(cur, j);
        //                if (!visited.Contains(down))
        //                {
        //                    queue.Enqueue(down);
        //                    visited.Add(down);
        //                }
        //            }
        //        }
        //        step++;
        //    }
        //    return -1;
        //}

        // 双向BFS,使用hashSet去重和判断重复
        private static int BFS(string[] deadends, string target)
        {
            ISet<string> q1 = new HashSet<string>();
            ISet<string> q2 = new HashSet<string>();
            int step = 0;
            q1.Add("0000");
            q2.Add(target);
            while (q1.Count != 0 && q2.Count!=0)
            {
                ISet<string> temp = new HashSet<string>();
                if(q1.Count > q2.Count)
                {
                    (q2, q1) = (q1, q2);
                }
                foreach(var cur in q1)
                {
                    visited.Add(cur);
                    if (q2.Contains(cur)) return step;
                    if (dead.Contains(cur)) continue;
                    for (int j = 0; j < 4; j++)
                    {
                        string up = Up(cur, j);
                        if(!visited.Contains(up))
                            temp.Add(up);
                        string down = Down(cur, j);
                        if (!visited.Contains(down))
                            temp.Add(down);
                    }
                }
                step++;
                q1 = q2;
                q2 = temp;
            }
            return -1;
        }

        /// <summary>
        /// 字符串索引j向上旋转
        /// </summary>
        /// <param name="s"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private static string Up(string s,int j)
        {
            char[] str = s.ToArray();
            if (str[j] == '9')
            {
                str[j] = '0';
            }
            else
                str[j] = (char)(str[j] + 1);
            return new string(str);
        }

        /// <summary>
        /// 字符串索引j向下旋转
        /// </summary>
        /// <param name="s"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private static string Down(string s,int j)
        {
            char[] str = s.ToArray();
            if (str[j] == '0')
            {
                str[j] = '9';
            }
            else
                str[j] = (char)(str[j] - 1);
            return new string(str);
        }
    }
}