using System;
using System.Collections.Generic;
/// <summary>
/// 给定一个可包含重复数字的序列 nums ，按任意顺序 返回所有不重复的全排列。
/// 输入：nums = [1,1,2]
//输出：
//[[1,1,2],
// [1,2,1],
// [2,1,1]]
/// </summary>
namespace Leet_47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,2, 2, 1 };
            var ret = PermuteUnique(nums);
        }
        public static List<List<int>> ans = new List<List<int>>();
        public static List<int> ret = new List<int>();
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            bool[] tag = new bool[nums.Length];
            Array.Sort(nums);
            GetList(nums, tag, 0);
            return ans.ToArray();
        }

        /// <summary>
        /// 使用标记数组，空间复杂度较高，可以将原来数组进行利用，count
        /// 左边的为使用过的，右边为没使用过的
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="tags"></param>
        /// <param name="count"></param>
        public static void GetList(int[] nums, bool[] tags, int count)
        {
            if (count == nums.Length)
            {
                ans.Add(new List<int>(ret));
                return;
            }
            for (int i = 0; i < nums.Length; i++) // 遍历，当有没使用过的数据时
            {
                // 对于1a1b和1b1a我们只取1a1b的话，那么只有当前一个取了后，我们才取这一个
                if (i > 0 && nums[i] == nums[i - 1] && !tags[i-1]) continue; // 前一个数据没用到
                if (!tags[i])
                {
                    ret.Add(nums[i]);
                    tags[i] = true;
                    GetList(nums, tags, count + 1);
                    // 回溯
                    ret.RemoveAt(ret.Count - 1);
                    tags[i] = false;
                }
            }
        }
    }
}
