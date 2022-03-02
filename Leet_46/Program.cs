using System;
using System.Collections.Generic;
// 给定一个不含重复数字的数组 nums ，返回其 所有可能的全排列 。你可以 按任意顺序 返回答案。
// 回溯算法。关键：增加标记数组
namespace Leet_46
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 1 };
            var ret = Permute(nums);
        }
        public static List<List<int>> ans = new List<List<int>>();
        public static List<int> ret = new List<int>();
        public static IList<IList<int>> Permute(int[] nums)
        {
            GetList(nums, 0);
            return ans.ToArray();
        }

        /// <summary>
        /// 使用标记数组，空间复杂度较高，可以将原来数组进行利用，count
        /// 左边的为使用过的，右边为没使用过的
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="tags"></param>
        /// <param name="count"></param>
        //public static void GetList(int[] nums,bool[] tags,int count)
        //{
        //    if (count == nums.Length)
        //    {
        //        ans.Add(new List<int>(ret));
        //        return;
        //    }
        //    for(int i = 0; i < nums.Length; i++) // 遍历，当有没使用过的数据时
        //    {
        //        if (!tags[i])
        //        {
        //            ret.Add(nums[i]);
        //            tags[i] = true;
        //            GetList(nums, tags, count + 1);
        //            // 回溯
        //            ret.Remove(nums[i]);
        //            tags[i] = false;
        //        }
        //    }
        //}

        // 使用原数组做标记，左边的是已经加入数组的
        public static void GetList(int[] nums, int count)
        {
            if (count == nums.Length)
            {
                ans.Add(new List<int>(ret));
                return;
            }
            for (int i = count; i < nums.Length; i++) // 遍历，当有没使用过的数据时
            {
                ret.Add(nums[i]);
                (nums[count], nums[i]) = (nums[i], nums[count]);
                GetList(nums, count + 1);
                (nums[count], nums[i]) = (nums[i], nums[count]);//回溯
                ret.Remove(nums[i]);
            }
        }
    }
}
