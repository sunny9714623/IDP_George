using System;
using System.Collections.Generic;
/// <summary>
/// 给你一个 无重叠的 ，按照区间起始端点排序的区间列表。
/// 在列表中插入一个新的区间，你需要确保列表中的区间仍然有序且不重叠（如果有必要的话，可以合并区间）。
/// </summary>
namespace Leet_57
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] test = new int[5][];
            //test[0] = new int[] { 1, 2 };
            //test[1] = new int[] { 3, 5 };
            //test[2] = new int[] { 6, 7 };
            //test[3] = new int[] { 8, 10 };
            //test[4] = new int[] { 12, 16 };
            int[][] test = new int[1][];
            test[0] = new int[] { 1, 5 };
            int[] newInterval = new int[] { 6, 8 };
            var ret = Insert(test, newInterval);
        }
        public static int[][] Insert(int[][] intervals,int[] newInterval)
        {
            List<int[]> merged = new List<int[]>();
            if (intervals.Length == 0)
            {
                merged.Add(newInterval);
                return merged.ToArray();
            }
            int i = 0, len = intervals.Length;
            // 左边没重叠
            while (i < len && intervals[i][1] < newInterval[0])
            {
                merged.Add(intervals[i]);
                i++;
            }
            // 开始有重叠, 这里这么思考，右边没重叠边界是intervals[i][0] > newInterval[1]
            if (i < len)
            {
                // 提取出来，减少在循环里进行Min操作，因为这里已经排序。
                newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            }
            while (i<len && intervals[i][0] <= newInterval[1])
            {
                newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
                i++;
            }
            merged.Add(newInterval);
            while (i < len)
            {
                merged.Add(intervals[i]);
                i++;
            }
            return merged.ToArray();
        }
    }
}
