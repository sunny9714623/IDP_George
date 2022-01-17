using System;
using System.Linq;

namespace Leet_16
{
    /// <summary>
    /// 给你一个长度为 n 的整数数组 nums 和 一个目标值 target。请你从 nums 中选出三个整数，使它们的和与 target 最接近。
    /// 返回这三个数的和。
    /// 假定每组输入只存在恰好一个解。
    /// </summary>
    class Program
    {
        /// <summary>
        /// 思路有点像三数之和
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,1,-1,-1,3 };///-1, 2, 1, -4
            Console.WriteLine(ThreeSumClosest(nums,-1));
        }
        public static int ThreeSumClosest(int[] nums,int target)
        {
            // ret进行判断是否是离target最近
            int resultOld = int.MaxValue, resultNew = 0;
            nums = nums.OrderBy(t => t).ToArray();
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1, k = nums.Length-1; j < k;)
                {
                    resultNew = nums[i] + nums[j] + nums[k];
                    if (resultNew - target > 0)
                    {
                        k--;
                        while (j < k && nums[k] == nums[k + 1]) k--;
                    }
                    else if (resultNew - target < 0)
                    {
                        j++;
                        while (j < k && nums[j] == nums[j - 1]) j++;
                    }
                    else
                    {
                        return resultNew;
                    }
                    resultOld = Math.Abs((double)resultNew - target) > Math.Abs((double)resultOld-target) ? resultOld : resultNew;
                }
            }
            return resultOld;
        }
    }
}
