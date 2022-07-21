using System;

namespace Leet_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int ret = MaxSubArray(ints);
        }

        /// <summary>
        /// 这个思想好好理解下，动态规划。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int max = nums[0], pre = 0;
            foreach (int num in nums)
            {
                pre = Math.Max(num, pre + num);
                max = Math.Max(pre, max);
            }
            return max;
        }
    }
}
