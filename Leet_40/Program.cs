using System;
using System.Collections;
using System.Collections.Generic;

namespace Leet_40
{
    class Program
    {
        public static List<int> res = new List<int>();
        public static List<List<int>> ans = new List<List<int>>();
        static void Main(string[] args)
        {
            int[] nums = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            CombinationSum2(nums, 8);
        }
        public static IList<IList<int>> CombinationSum2(int[] candidates,int target)
        {
            GetSumIndex(candidates, target, 0);
            return ans.ToArray();
        }
        public static void GetSumIndex(int[] candidates, int target, int index)
        {
            if (target == 0)
            {
                ans.Add(new List<int>(res));
                return;
            }
            if (index == candidates.Length) return;
            if (target - candidates[index] >= 0)
            {
                res.Add(candidates[index]);
                GetSumIndex(candidates, target - candidates[index], index + 1);
                res.RemoveAt(res.Count - 1);
            }
            GetSumIndex(candidates, target, index + 1);
        }
    }
}
