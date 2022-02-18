using System;

namespace Leet_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 4, 5, 6, 1, 10 };
            int ret = FirstMissingPositive(nums);
        }
        public static int FirstMissingPositive(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] < nums.Length)
                {
                    (nums[nums[i]]) = (nums[i]);
                }
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if (i != nums[i])
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
