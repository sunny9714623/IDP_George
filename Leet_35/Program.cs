using System;
/// <summary>
/// 给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
/// 请必须使用时间复杂度为 O(log n) 的算法。
/// </summary>

namespace Leet_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int result = SearchInsert(nums, 5);
        }
        /// <summary>
        /// 暴力法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="traget"></param>
        /// <returns></returns>
        //public static int SearchInsert(int[] nums,int target)
        //{
        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] >= target)
        //        {
        //            return i;
        //        }
        //    }
        //    return nums.Length;
        //}

        // 二分查找
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums[0] > target) { return 0; }
            if (nums[nums.Length - 1] < target) { return nums.Length; }
            int left = 0, right = nums.Length - 1, mid = 0;
            while (left <= right)
            {
                mid = (right + left) / 2;
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            if (nums[mid] > target)
            {
                return mid;
            }
            else
            {
                return mid + 1;
            }
        }
    }
}
