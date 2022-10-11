namespace Leet_0801
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// 明显使用dp算法。动态规划
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public int WaysToStep(int n)
        //{
        //    if (n <= 2) return n;
        //    int[] dp = new int[n + 1];
        //    dp[1] = 1; dp[2] = 2; dp[3] = 4;
        //    for(int i = 4; i <= n; i++)
        //    {
        //        dp[i] = ((dp[i - 1] + dp[i-2]) % 1000000007 + dp[i-3]) % 1000000007;
        //    }
        //    return dp[n];
        //}

        //只用四个变量做dp,只维护数组中的前三个元素。求出第四个元素后，第一个元素就没用了
        public int WaysToStep(int n)
        {
            if (n <= 2) return n;
            if (n == 3) return 4;
            int[] dp = new int[4];
            dp[0] = 1; dp[1] = 2; dp[2] = 4;
            for (int i = 4; i <= n; i++)
            {
                dp[3] = ((dp[2] + dp[1]) % 1000000007 + dp[0]) % 1000000007;
                dp[0] = dp[1];
                dp[1] = dp[2];
                dp[2] = dp[3];
            }
            return dp[3];
        }
    }
}