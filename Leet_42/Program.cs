using System;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// 给定 n 个非负整数表示每个宽度为 1 的柱子的高度图，计算按此排列的柱子，下雨之后能接多少雨水。
/// </summary>
namespace Leet_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int ret = Trap(height);
        }

        /// <summary>
        /// 时间复杂度O(n^2)，超出时间限制。
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        //public static int Trap(int[] height)
        //{
        //    int ans = 0;
        //    for(int i = 0; i < height.Length - 1; i++)
        //    {
        //        int leftmax = 0, rightmax = 0;
        //        for (int j = i; j < height.Length; j++)
        //        {
        //            rightmax = Math.Max(rightmax, height[j]);
        //        }
        //        for(int j = i; j >= 0; j--)
        //        {
        //            leftmax = Math.Max(leftmax, height[j]);
        //        }
        //        ans += Math.Min(leftmax, rightmax) - height[i];
        //    }
        //    return ans;
        //}

        ///动态规划
        //public static int Trap(int[] height)
        //{
        //    int ans = 0;
        //    int length = height.Length;
        //    int[] leftMax = new int[length], rightMax = new int[length];
        //    leftMax[0] = height[0]; rightMax[length - 1] = height[length - 1];
        //    /// 记录当前的左边最大值
        //    for(int i = 1; i < height.Length; i++)
        //    {
        //        leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
        //    }
        //    for(int i = length - 2; i >= 0; i--)
        //    {
        //        rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
        //    }
        //    for(int i = 1; i < length - 1; i++)
        //    {
        //        ans += Math.Min(leftMax[i], rightMax[i]) - height[i];
        //    }
        //    return ans;
        //}

        ///使用递减栈
        public static int Trap(int[] height)
        {
            int ans = 0, i = 0;
            Stack<int> s = new Stack<int>(); // 这里需要存索引，而不是存高度
            while (i < height.Length)
            {
                while (s.Count != 0 && height[i] > height[s.Peek()])
                {
                    int nowIndex = s.Pop();
                    if (s.Count == 0)
                    {
                        break; // 没有左边的，跳出循环
                    }
                    int leftIndex = s.Peek();
                    int width = i - leftIndex - 1;
                    int high = Math.Min(height[leftIndex], height[i]) - height[nowIndex];
                    ans += width * high;
                }
                s.Push(i++);
            }
            return ans;
        }
    }
}
