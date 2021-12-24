using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace IDP_George
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3,2,4 };
            int[] rlt = TwoSum(nums, 6);
        }

        //public static int[] TwoSum(int[] nums, int target)
        //{
        //    int[] ret = new int[2];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] + nums[j] == target)
        //            {
        //                ret[0] = i;
        //                ret[1] = j;
        //                break;
        //            }
        //        }
        //    }
        //    return ret;
        //}

        // 进阶 //二分查找不行。因为会打乱顺序。索引不是有用的,方法错误
        //public static int[] TwoSum(int[] nums, int target)
        //{
        //    int[] ret = new int[2];
        //    int[] numscopy = nums.OrderBy(t => t).ToArray();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int j = target - nums[i];
        //        int m = binarrysearch(numscopy, j);
        //        if (m != -1)
        //        {
        //            ret[1] = nums.AsEnumerable().ToList().IndexOf(j);
        //            ret[0] = i;
        //            break;
        //        }
        //    }
        //    return ret;
        //}
        //public static int binarrysearch(int[] numscopy, int j)
        //{
        //    int left = 0, right = numscopy.Length - 1, median = numscopy.Length / 2;
        //    if (right < left) return -1;
        //    while (left <= right)
        //    {
        //        if (numscopy[median] == j) return median;
        //        else if (numscopy[median] > j)
        //        {
        //            right = median - 1;
        //        }
        //        else
        //        {
        //            left = median + 1;
        //        }
        //        median = left + (right - left) / 2;
        //    }
        //    return -1;
        //}

        // 使用Hashtable进行存储,
        public static int[] TwoSum(int[] nums, int target)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (ht.Contains(target - nums[i]))
                {
                    return new int[] { int.Parse(ht[target - nums[i]].ToString()), i };
                }
                if (ht.Contains(nums[i])) continue; // 不能存储相同的key，所以这里加层判断。
                ht.Add(nums[i],i);
            }
            return new int[0];
        }
    }
}
