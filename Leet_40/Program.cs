using System;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// 给定一个候选人编号的集合 candidates 和一个目标数 target ，找出 candidates
/// 中所有可以使数字和为 target 的组合。
/// candidates 中的每个数字在每个组合中只能使用 一次 。
/// 注意：解集不能包含重复的组合。
/// </summary>
namespace Leet_40
{
    class Program
    {
        public static List<int> res = new List<int>();
        public static List<List<int>> ans = new List<List<int>>();
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,1,2,6 };
            CombinationSum2(nums, 9);
        }
        public static IList<IList<int>> CombinationSum2(int[] candidates,int target)
        {
            Array.Sort(candidates);
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
            for(int i = index; i < candidates.Length; i++) // 进入一层for，并且i=index，说明index被选了，
                                                           // i==index说明刚选这个，执行一次循环一定会选一个数
            {
                if (i > index && candidates[i] == candidates[i - 1]) continue;
                if (target - candidates[i] >= 0)
                {
                    res.Add(candidates[i]);
                    GetSumIndex(candidates, target - candidates[i], i + 1);
                    res.RemoveAt(res.Count - 1);
                }
                else //剪枝
                {
                    break;
                }
            }
        }
    }
}
