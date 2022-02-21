using System;
/// <summary>
/// 给你一个未排序的整数数组 nums ，请你找出其中没有出现的最小的正整数。
/// 请你实现时间复杂度为 O(n) 并且只使用常数级别额外空间的解决方案。
/// </summary>
namespace Leet_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 4, 5, 6, 1, 10};
            int ret = FirstMissingPositive(nums);
        }
        /// <summary>
        /// 第一遍for循环，将正数归位。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FirstMissingPositive(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                while (nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i]-1] != nums[i])
                {
                    (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]); // 一遍交换可能没有归位，要使用while
                }
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if (i+1 != nums[i])
                {
                    return i+1;
                }
            }
            return nums.Length + 1;
        }
    }
}
