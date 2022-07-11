using System;

///给定一个包含非负整数的 m x n 网格 grid ，请找出一条从左上角到右下角的路径，使得路径上的数字总和为最小。
///说明：每次只能向下或者向右移动一步。
namespace Leet_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[3][] { new int[3] { 1, 3, 1 }, new int[3] { 1, 5, 1 }, new int[3] { 4, 2, 1 } };
            var res = MinPathSum1(grid);
        }
        public static int MinPathSum(int[][] grid)
        {
            int[,] dp = new int[grid.Length, grid[0].Length];
            dp[0,0] = grid[0][0];
            for(int i = 1; i < grid.Length; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + grid[i][0];
            }
            for (int j = 1; j < grid[0].Length; j++)
            {
                dp[0, j] = dp[0, j - 1] + grid[0][j];
            }
            for(int i = 1; i < grid.Length; i++)
            {
                for(int j = 1; j < grid[0].Length; j++)
                {
                    dp[i,j] = Math.Min(dp[i - 1,j], dp[i,j - 1]) + grid[i][j];
                }
            }
            return dp[grid.Length - 1, grid[0].Length - 1];
        }

        public static int MinPathSum1(int[][] grid)
        {
            // 滚动数组
            int[] dp = new int[grid[0].Length];
            dp[0] = grid[0][0];
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    // 第一行的元素
                    if (i == 0 && j > 0)
                    {
                        dp[j] = dp[j - 1] + grid[i][j];
                    }
                    // 第一列的元素
                    if (j == 0 && i > 0)
                    {
                        dp[j] = dp[j] + grid[i][j];
                    }
                    if(i>0&&j>0)
                    {
                        dp[j] = Math.Min(dp[j - 1], dp[j]) + grid[i][j];
                    }
                }
            }
            return dp[grid[0].Length - 1];
        }
    }
}
