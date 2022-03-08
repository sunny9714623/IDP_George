﻿using System;
using System.Collections.Generic;
/// <summary>
/// 以数组 intervals 表示若干个区间的集合，其中单个区间为 intervals[i] = [starti, endi] 。
/// 请你合并所有重叠的区间，并返回 一个不重叠的区间数组，该数组需恰好覆盖输入中的所有区间 。
/// 方法：按照左端点排序：注意拍完序后所有能够合并的区间一定是连续的
/// </summary>
namespace Leet_56
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] test = new int[3][];
            test[0] = new int[] { 1, 6 };
            test[1] = new int[] { 8, 10 };
            test[2] = new int[] { 15, 18 };
        }
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> merged = new List<int[]>();
            // 对二维数组进行排序
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
            merged.Add(intervals[0]);
            foreach(var interval in intervals)
            {

            }
            return null;
        }
    }
}