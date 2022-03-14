using System;

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
