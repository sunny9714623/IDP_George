using System;
/// <summary>
/// 一个机器人位于一个 m x n 网格的左上角 （起始点在下图中标记为 “Start” ）。
/// 机器人每次只能向下或者向右移动一步。机器人试图达到网格的右下角（在下图中标记为 “Finish”）。
/// 现在考虑网格中有障碍物。那么从左上角到右下角将会有多少条不同的路径？
/// 网格中的障碍物和空位置分别用 1 和 0 来表示。
/// </summary>
namespace Leet_63
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] path = new int[3][];
            path[0] = new int[] { 0, 0, 0 };
            path[1] = new int[] { 0, 1, 0 };
            path[2] = new int[] { 0, 0, 0 };
            var ret = UniquepathsWithObstacles(path);
        }
        /// <summary>
        /// 动态规划
        /// 使用二维数组，然后定义边界值，这里用两个循环定义第一行
        /// 第一列的边界值
        /// </summary>
        /// <param name="obstacleGrid"></param>
        /// <returns></returns>
        //public static int UniquepathsWithObstacles(int[][] obstacleGrid)
        //{
        //    var move = new int[obstacleGrid.Length, obstacleGrid[0].Length];
        //    move[0,0] = (obstacleGrid[0][0] == 0 ? 1 : 0);
        //    for(int j = 0; j < obstacleGrid[0].Length && obstacleGrid[0][j]==0; j++)
        //    {
        //        move[0,j] = 1;
        //    }
        //    for (int i = 0; i < obstacleGrid.Length && obstacleGrid[i][0] == 0; i++)
        //    {
        //        move[i,0] = 1;
        //    }
        //    for (int i = 1; i < obstacleGrid.Length; i++)
        //    {
        //        for (int j = 1; j < obstacleGrid[0].Length; j++)
        //        {
        //            if (obstacleGrid[i][j] == 0)
        //            {
        //                move[i, j] = move[i - 1, j] + move[i, j - 1];
        //            }
        //        }
        //        //if (obstacleGrid[i][j] == 1)
        //        //{
        //        //    move[j] = 0;
        //        //    continue;
        //        //}
        //        //if (j - 1 >= 0)
        //        //{
        //        //    move[j] = move[j] + move[j - 1];
        //        //}
        //    }
        //    return move[obstacleGrid.Length - 1, obstacleGrid[0].Length - 1];
        //}

        // 动态规划，并且使用滚动数组
        // 这里注意动态规划方程
        public static int UniquepathsWithObstacles(int[][] obstacleGrid)
        {
            var move = new int[obstacleGrid[0].Length];
            move[0] = obstacleGrid[0][0] == 1 ? 0 : 1;
            for(int i = 0; i < obstacleGrid.Length; i++)
            {
                for(int j = 0; j < obstacleGrid[0].Length; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        move[j] = 0;
                        continue;
                    }
                    if (j - 1 >= 0)
                    {
                        move[j] = move[j] + move[j - 1];
                    }
                }
            }
            return move[obstacleGrid[0].Length - 1];
        }
    }
}
