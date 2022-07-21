using System;

namespace Leet_55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 1, 8, 0, 1 };
            var ret = CanJump(nums);
        }

        /// <summary>
        /// 从后往前遍历，排除最后一个(最后一个可以为0),如果发现有0的值，就判断有没有前面某个索引处的值加索引大于这个0的索引，
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public static bool CanJump(int[] nums)
        // {
        //    if (nums == null || nums.Length == 1)
        //    {
        //        return true;
        //    }
        //    for(int i = nums.Length - 2; i >= 0; i--)
        //    {
        //        if (nums[i]==0)
        //        {
        //            int j;
        //            for(j = i - 1; j >= 0; j--)
        //            {
        //                if (nums[j] + j > i) break;
        //            }
        //            if (j == -1)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}


        /// 贪心算法
        public static bool CanJump(int[] nums)
        {
            if (nums == null || nums.Length == 1)
            {
                return true;
            }
            int length = nums.Length - 1;
            int rightMax = 0;// 目前最远可达的位置
            for(int i = 0; i < length; i++)
            {
                if (i <= rightMax)
                {
                    rightMax = Math.Max(rightMax, i + nums[i]);
                }
                if (rightMax >= length) return true;
            }
            return false;
        }
    }
}
