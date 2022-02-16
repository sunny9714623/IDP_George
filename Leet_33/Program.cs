using System;
/// <summary>
/// 这道题思路很棒
/// 看了官方题解，确实简洁很多，也更能体现二分查找的特点。
/// 对于二分查找的题目，重点就是二分后如何舍弃一半。
/// 经典的二分查找算法中，由于单调递增性，通过比较mid元素和target就可以确认舍弃哪一半。
/// 这个题目中，由于rotation破坏了单调递增性，比较mid元素和target不足以确认该舍弃哪一半。
/// 关键点就在于单调递增性。如何获取单调递增性呢？通过比较mid元素和第一个元素就可以确认
/// [0..mid]和[mid..n-1]哪一部分是具备单调递增性的，由此再和target比较来确认该舍弃哪一半。
/// 
/// 整数数组 nums 按升序排列，数组中的值 互不相同 。
/// 在传递给函数之前，nums 在预先未知的某个下标 k（0 <= k < nums.length）上进行了 旋转，使数组变为 [nums[k], nums[k + 1], ..., nums[n - 1], nums[0], nums[1], ..., nums[k - 1]]（下标 从 0 开始 计数）。例如， [0,1,2,4,5,6,7] 在下标 3 处经旋转后可能变为[4, 5, 6, 7, 0, 1, 2] 。
/// 给你 旋转后 的数组 nums 和一个整数 target ，如果 nums 中存在这个目标值 target ，则返回它的下标，否则返回 -1 。
/// </summary>
namespace Leet_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {9,10,0,1,3,4,5 };
            int ret = Search(nums, 3);
        }

        /// <summary>
        /// 暴力法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        //public static int Serch(int[] nums,int target)
        //{
        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == target) return i;
        //    }
        //    return -1;
        //}
        public static int Search(int[] nums, int target)
        {
            int n = nums.Length;
            if (n == 0)
            {
                return -1;
            }
            if (n == 1)
            {
                return nums[0] == target ? 0 : -1;
            }
            int left = 0, right = nums.Length - 1, mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                // 左边有序[0,mid]，利用有序数组二分查找
                if (nums[0] <= nums[mid])
                {
                    if (nums[0] <= target && nums[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                // 右边有序[mid,n-1]
                else
                {
                    if (target > nums[mid] && target <= nums[n - 1])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
