using System;
using System.Collections.Generic;

namespace Leet_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] ints = { new int[] { 1, 2, 3, 4, 100 }, new int[] { 5, 6, 7, 8,101 }, new int[] { 9, 10, 11, 12,102 } };
            var result = SpiralOrder(ints);
        }

        // 通过控制方向来操作遍历二维数组。
        //public static IList<int> SpiralOrder(int[][] matrix)
        //{
        //    List<int> ret = new List<int>();
        //    int left = -1, right = matrix[0].Length, top = -1, down = matrix.Length;
        //    int i=0,j=0;
        //    while (left + 1 < right && top + 1 < down)
        //    {
        //        while (left < j && j < right && left + 1 < right)
        //        {
        //            ret.Add(matrix[i][j++]);
        //        }
        //        if (ret.Count == matrix[0].Length * matrix.Length) break;
        //        top++;
        //        i++;
        //        j--;
        //        while (top < i && i < down && top +1 < down)
        //        {
        //            ret.Add(matrix[i++][j]);
        //        }
        //        if (ret.Count == matrix[0].Length * matrix.Length) break;
        //        right--;
        //        j--;
        //        i--;
        //        while(left < j && j < right && left + 1 < right)
        //        {
        //            ret.Add(matrix[i][j--]);
        //        }
        //        if (ret.Count == matrix[0].Length * matrix.Length) break;
        //        down--;
        //        i--;
        //        j++;
        //        while (top < i && i < down && top + 1 < down)
        //        {
        //            ret.Add(matrix[i--][j]);
        //        }
        //        if (ret.Count == matrix[0].Length * matrix.Length) break;
        //        left++;
        //        i++;
        //        j++;
        //    }
        //    return ret;
        //}

        /// <summary>
        /// 模拟，这个定义的比较清楚
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        //public static IList<int> SpiralOrder(int[][] matrix)
        //{
        //    List<int> ret = new List<int>();
        //    if(matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
        //    {
        //        return ret;
        //    }
        //    int rows = matrix.Length, columns = matrix[0].Length;
        //    bool[,] visited = new bool[rows,columns];
        //    int total = rows * columns;
        //    int[][] destin = new int[][] { new int[] { 0,1},new int[] { 1, 0 },new int[] { 0,-1},new int[] { -1,0} };
        //    int row = 0, column = 0;
        //    int destinIndex = 0;
        //    for(int i = 0; i < total; i++)
        //    {
        //        ret.Add(matrix[row][column]);
        //        visited[row, column] = true;
        //        int nextRow = row + destin[destinIndex][0], nextColumn = column + destin[destinIndex][1];
        //        if(nextRow < 0 || nextRow >= rows || nextColumn<0 || nextColumn>=columns || visited[nextRow, nextColumn])
        //        {
        //            destinIndex = (destinIndex + 1) % 4;
        //        }
        //        row += destin[destinIndex][0]; column += destin[destinIndex][1];
        //    }
        //    return ret;
        //}


        /// <summary>
        /// 模拟，从外圈到内圈，同第一个方法。
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> ret = new List<int>();
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return ret;
            }
            int rows = matrix.Length, columns = matrix[0].Length;
            int left = 0, right = columns - 1, down = rows - 1, up = 0;
            while(left<=right && up <= down)
            {
                for(int column = left; column <= right; column++)
                {
                    ret.Add(matrix[up][column]);
                }
                for(int row = up + 1; row <= down; row++)
                {
                    ret.Add(matrix[row][right]);
                }
                if(left < right && up < down)
                {
                    // 这里判断条件有区别
                    for(int column = right - 1; column > left; column--)
                    {
                        ret.Add(matrix[down][column]);
                    }
                    for(int row = down; row > up; row--)
                    {
                        ret.Add(matrix[row][left]);
                    }
                }
                left++;
                right--;
                up++;
                down--;
            }
            return ret;
        }
    }
}
