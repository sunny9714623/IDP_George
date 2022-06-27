using System;
/// <summary>
/// 给你一个非负整数数组 nums ，你最初位于数组的第一个位置。
/// 数组中的每个元素代表你在该位置可以跳跃的最大长度。
/// 你的目标是使用最少的跳跃次数到达数组的最后一个位置。
/// 假设你总是可以到达数组的最后一个位置。
/// [2,3,1,1,4]
/// </summary>
namespace Leet_45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2,3,1,1,4};
            int ret = Jump(nums);
        }

        /// <summary>
        /// 贪心算法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Jump(int[] nums)
        {
            int step = 0;
            int masPosition = 0;
            // 定义边界
            int end = 0;
            for(int i = 0; i < nums.Length -1 ; i++) // 使用nums.length-1的原因：
                                                     // 1.如果移动下标等于当前覆盖最大距离下标，
                                                     // 需要再走一步（即ans++），因为最后一步一定是可以到的终点。
                                                     // （题目假设总是可以到达数组的最后一个位置）
                                                     // 2.如果移动下标不等于当前覆盖最大距离下标，
                                                     // 说明当前覆盖最远距离就可以直接达到终点了，不需要再走一步
            {
                masPosition = Math.Max(masPosition, nums[i] + i);
                if (i == end) //一定可用到达终点
                {
                    end = masPosition;// 更新边界
                    step++;
                }
            }
            return step;
        }
        
    }
}
