using System;

namespace Leet_26
{
    /// <summary>
    /// 给你一个有序数组 nums ，请你 原地 删除重复出现的元素，使每个元素 只出现一次 ，返回删除后数组的新长度。
    /// 不要使用额外的数组空间，你必须在 原地 修改输入数组 并在使用 O(1) 额外空间的条件下完成。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0,0,1,1,1,2,2,3,3,4 };
            int result = RemoveDuplicates(nums);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int curIndex,curNumber,preIndex=0;
            // 如果只有一个元素
            if (nums.Length == 0)
            {
                return 0;
            }
            curIndex = 0; curNumber = nums[curIndex];
            // 如果全是重复元素，返回1
            if (nums[curIndex] == nums[nums.Length - 1])
            {
                return 1;
            }
            // 遍历
            while (curIndex < nums.Length )
            {
                if (nums[preIndex] != nums[curIndex]) nums[++preIndex] = nums[curIndex];
                curIndex++;
            }
            return ++preIndex;
        }
    }
}
