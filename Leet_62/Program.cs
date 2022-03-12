using System;
/// <summary>
/// 一个机器人位于一个 m x n 网格的左上角 （起始点在下图中标记为 “Start” ）。
/// 机器人每次只能向下或者向右移动一步。机器人试图达到网格的右下角（在下图中标记为 “Finish” ）。
/// 问总共有多少条不同的路径？
/// </summary>
namespace Leet_62
{
    class Program
    {
        static void Main(string[] args)
        {
            int rt = UniquePaths(3, 7);
        }

        // dfs+回溯  超时
        //public static int count;
        //public static int UniquePaths(int m,int n)
        //{
        //    int[][] move = new int[2][];
        //    move[0] = new int[] { 0, 1 }; //向右移动
        //    move[1] = new int[] { 1, 0 }; // 向下移动
        //    TotalPaths(move, m, n, 1, 1);
        //    return count;
        //}
        //public static void TotalPaths(int[][] move,int m,int n,int curm,int curn)
        //{
        //    if(curm == m && curn == n)
        //    {
        //        // 到达右下角
        //        count++;
        //        return;
        //    }
        //    if (curm > m || curn > n)
        //    {
        //        // 到达边界 减枝
        //        return;
        //    }
        //    for(int i = 0; i < move.Length; i++)
        //    {
        //        curm += move[i][0];
        //        curn += move[i][1];
        //        TotalPaths(move, m, n, curm, curn);
        //        // 回溯
        //        curm -= move[i][0];
        //        curn -= move[i][1];
        //    }
        //}

        /// <summary>
        ///  使用动态规划
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        //public static int UniquePaths(int m,int n)
        //{

        //}

        /// 使用组合数学
        //public static int UniquePaths(int m, int n)
        //{
        //    long ans = 1;
        //    for(int i = n, y = 1; y < m; i++, y++)
        //    {
        //        ans = ans * i / y;
        //    }
        //    return (int)ans;
        //}

        /// 使用二维数组+动态规划
        //public static int UniquePaths(int m, int n)
        //{
        //    var move = new int[m, n];
        //    for(int i = 0; i < m; i++)
        //    {
        //        for(int j = 0; j < n; j++)
        //        {
        //            if (i == 0 || j == 0)
        //            {
        //                move[i, j] = 1;
        //            }
        //            else
        //            {
        //                move[i, j] = move[i - 1, j] + move[i, j - 1];
        //            }
        //        }
        //    }
        //    return move[m - 1, n - 1];
        //}

        // 使用一维数组+动态规划：因为二维数组总是从左到右,从上到下计算的
        // 所以这里可以使用一位数组。
        // 我们可以把m x n的二维dp数组优化成长度为n的一维dp数组，也就是说dp[j]只依赖dp[j]和dp[j-1]。
        // 其中：
        // dp[j] 表示dp[i - 1][j]
        // dp[j - 1] 表示dp[i][j-1]
        public static int UniquePaths(int m, int n)
        {
            var move = new int[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        move[j] = 1;
                    }
                    else
                    {
                        move[j] = move[j] + move[j - 1];
                    }
                }
            }
            return move[n - 1];
        }
    }
}
