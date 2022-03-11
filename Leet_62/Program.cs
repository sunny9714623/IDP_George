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
            int rt = UniquePaths(23, 12);
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
        public static int UniquePaths(int m, int n)
        {
            int min = Math.Min(m, n);
            int ans = 1;
            for(int i = Math.Max(m,n), y = 1; y < min; i++, y++)
            {
                ans *= ans * i / y;
            }
            return ans;
        }
    }
}
