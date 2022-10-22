using System;
using System.Collections.Generic;

namespace Leet_78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            Subsets(nums);
        }
        static IList<int> temp = new List<int>();
        static IList<IList<int>> ans = new List<IList<int>>();
        public static IList<IList<int>> Subsets(int[] nums)
        {
            DFS(nums, 0);
            return ans;
        }

        public static void DFS(int[] nums, int cur)
        {
            ans.Add(new List<int>(temp));
            for (int i = cur; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                DFS(nums, i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }

        //public static void DFS(int[] nums, int cur)
        //{
        //    if(cur == nums.Length)
        //    {
        //        ans.Add(new List<int>(temp));
        //        return;
        //    }
        //    temp.Add(nums[cur]);
        //    DFS(nums, cur + 1);
        //    temp.RemoveAt(temp.Count - 1);
        //    DFS(nums, cur + 1);
        //}
    }
}
