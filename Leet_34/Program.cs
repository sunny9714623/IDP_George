using System;
/// <summary>
/// 给定一个按照升序排列的整数数组 nums，和一个目标值 target。找出给定目标值在数组中的开始位置和结束位置。
/// 如果数组中不存在目标值 target，返回 [-1, -1]。
/// 进阶：
/// 你可以设计并实现时间复杂度为 O(log n) 的算法解决此问题吗？
/// </summary>
namespace Leet_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {7 };
            int[] result = SearchRange(nums, 7);
        }
        /// <summary>
        /// 分析 ： 找左边界就是找第一个大于等于target的，找右边界就是找第一个大于target，就是大于等于target+1
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] SearchRange(int[] nums,int target)
        {
            int leftIndex = BinarrySearch(nums, target);
            int rightIndex = BinarrySearch(nums, target + 1);
            if (leftIndex >=0 && leftIndex < nums.Length && nums[leftIndex] == target)
            {
                return new int[] { leftIndex, rightIndex-1 };//如果左边界存在，那么右边界一定存在
            }
            return new int[] { -1, -1 };
        }
        /// <summary>
        /// 查找第一个大于等于target的下标
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarrySearch(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1, mid;
            int ans = 0;
            if (nums.Length == 0)
            {
                return -1; // 数组为空
            }
            if (nums[right] < target)
            {
                return nums.Length; // 当target>数组中的任何值时，返回数组长度
            }
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (nums[mid] >= target)
                {
                    right = mid - 1;
                    ans = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }
    }
}
