using System;
/// <summary>
/// 给你一个正整数 n ，生成一个包含 1 到 n2 所有元素，且元素按顺时针顺序螺旋排列的 n x n 正方形矩阵 matrix 。
/// 输入：n = 3
/// 输出：[[1,2,3],[8,9,4],[7,6,5]]
/// </summary>
namespace Leet_59
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = GenerateMatrix(3);
        }
        //public static int[][] GenerateMatrix(int n)
        //{
        //    int[][] ret = new int[n][];
        //    for(int i = 0; i < n; i++)
        //    {
        //        ret[i] = new int[n];
        //    }
        //    int row = 0, column = 0;
        //    // move 分别代表右下左上
        //    int[][] move = { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };
        //    int curNum = 1;
        //    int nextmove = 0;
        //    while (curNum <= n * n)
        //    {
        //        ret[row][column]= curNum;
        //        curNum++;
        //        int nextRow = row + move[nextmove][0], nextColumn = column + move[nextmove][1];
        //        if (nextRow < 0 || nextRow >= n || nextColumn < 0 || nextColumn >= n || ret[nextRow][nextColumn] != 0)
        //        {
        //            nextmove = (++nextmove) % 4;
        //        }
        //        row = row + move[nextmove][0];
        //        column = column + move[nextmove][1];
        //    }
        //    return ret;
        //}

        /// <summary>
        /// 按照层次填入，先填最外层。每次都是从外向内四个方向
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[][] GenerateMatrix(int n)
        {
            int[][] ret = new int[n][];
            for (int i = 0; i < n; i++)
            {
                ret[i] = new int[n];
            }
            // left,rigt,down,up分别代表四个边界
            int left = 0, right = n - 1, up = 0, down = n - 1;
            int index = 1;
            while (index <= n * n)
            {
                for(int i = left; i <= right; i++)
                {
                    ret[up][i] = index;
                    index++;
                }
                up++;
                for(int i = up; i <= down; i++)
                {
                    ret[i][right] = index;
                    index++;
                }
                right--;
                for(int i = right; i >= left; i--)
                {
                    ret[down][i] = index;
                    index++;
                }
                down--;
                for(int i = down; i >= up; i--)
                {
                    ret[i][left] = index;
                    index++;
                }
                left++;
            }
            return ret;
        }
    }
}
