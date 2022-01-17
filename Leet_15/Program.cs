using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Leet_15
{
    /// <summary>
    /// 给你一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0 ？请你找出所有和为 0 且不重复的三元组。
    /// 注意：答案中不可以包含重复的三元组。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };//-1,0,1,2,-1,-4
            var total = ThreeSum(nums);
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            nums = nums.OrderBy(t => t).ToArray();
            // 排序后进行处理，这里排序后就可以利用双指针，遍历时间复杂度为O(n)。
            List<List<int>> ret=new List<List<int>>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for(int j = i + 1, k = nums.Length - 1; j < k;)
                {
                    if (j > i+1 && nums[j] == nums[j - 1])
                    {
                        j++;
                        continue;
                    }
                    int total = 0 - nums[i];
                    if (nums[j] + nums[k] > total)
                    {
                        k--;
                        while (j < k && nums[k] == nums[k + 1]) k--;
                    }
                    else if(nums[j]+nums[k]<total)
                    {
                        j++;
                        while (j < k && nums[j] == nums[j - 1]) j++;
                    }
                    else
                    {
                        ret.Add(new int[] { nums[i], nums[j], nums[k] }.ToList());
                        j++;k--;
                        while (j < k && nums[k] == nums[k + 1]) k--;
                        while (j < k && nums[j] == nums[j - 1]) j++;
                    }
                }
            }
            return ret.ToArray();
        }
    }
}
