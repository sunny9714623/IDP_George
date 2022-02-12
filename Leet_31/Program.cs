using System;

namespace Leet_31
{
    /// <summary>
    /// 下一个排列
    /// 整数数组的 下一个排列 是指其整数的下一个字典序更大的排列。更正式地，如果数组的所有排列根据其字典顺序从小到大排列在一个容器中，那么数组的 下一个排列 就是在这个有序容器中排在它后面的那个排列。如果不存在下一个更大的排列，那么这个数组必须重排为字典序最小的排列（即，其元素按升序排列）。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,2,3 };
            NextPermutation(nums);
        }
        //public static void NextPermutation(int[] nums)
        //{
        //    int min = int.MinValue;
        //    for(int i = nums.Length - 2; i >= 0; i--)
        //    {
        //        if (nums[i] < nums[i + 1])
        //        {
        //            min = i;
        //            break;
        //        }
        //    }
        //    if (min == int.MinValue)
        //    {
        //        ReverseNextI(nums, -1);
        //    }
        //    else
        //    {
        //        for(int i = nums.Length - 1; i >= 0; i--)
        //        {
        //            if (nums[i] > nums[min])
        //            {
        //                swap(nums, i, min);
        //                ReverseNextI(nums, min);
        //                break;
        //            }
        //        }
        //    }
        //}
        //public static void swap(int[] nums,int i,int j)
        //{
        //    int temp = nums[i];
        //    nums[i] = nums[j];
        //    nums[j] = temp; ;
        //}
        //public static void ReverseNextI(int[] nums,int i)
        //{
        //    int left = i + 1, right = nums.Length - 1;
        //    while (left < right)
        //    {
        //        swap(nums, left, right);
        //        left++;
        //        right--;
        //    }
        //}

        public static void NextPermutation(int[] nums)
        {
            var NoNeed = true;
            for(int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] > nums[i - 1])
                {
                    ReverseNextI(nums, i-1);
                    for(int j = i; j < nums.Length; j++)
                    {
                        if (nums[j] > nums[i - 1])
                        {
                            (nums[i - 1], nums[j]) = (nums[j], nums[i - 1]);
                            break;
                        }
                    }
                    NoNeed = false;
                    break;
                }
            }
            if (NoNeed) ReverseNextI(nums, -1);
        }

        public static void ReverseNextI(int[] nums, int i)
        {
            for (int left = i + 1, right = nums.Length - 1; left < right; left++, right--)
            {
                // 可以这样交换两个数 元组类型交换
                (nums[left], nums[right]) = (nums[right], nums[left]);
            }
        }
    }
}
