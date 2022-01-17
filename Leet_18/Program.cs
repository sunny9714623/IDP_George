using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Leet_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, -1, -1, 1, 1, 2, 2 };
            FourSum(nums, 0);
        }
        public static IList<IList<int>> FourSum(int[] nums,int target)
        {
            var ans = new List<List<int>>();
            nums = nums.OrderBy(t => t).ToArray();
            bool flag = true;
            for(int i = 0; i < nums.Length; i++)
            {
                /// 去重
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    /// 去重
                    if (j > i+1 && nums[j] == nums[j - 1])
                    {
                        if (flag)
                        {
                            flag = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    for(int k = j + 1, l = nums.Length - 1; k < l;)
                    {
                        int total = nums[i] + nums[j] + nums[k] + nums[l];
                        if (total == target)
                        {
                            ans.Add(new List<int> { nums[i] , nums[j] , nums[k] , nums[l] });
                            k++;l--;
                            while (k < l && (nums[k] == nums[k - 1])) k++;
                            while (k < l && (nums[l] == nums[l + 1])) l--;
                        }
                        if (total > target && k < l) l--;
                        if (total < target && k < l) k++;
                    }
                }
            }
            return ans.ToArray();
        }
    }
}
