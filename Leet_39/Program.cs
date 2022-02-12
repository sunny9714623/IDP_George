using System;
using System.Collections.Generic;

namespace Leet_39
{
    /// <summary>
    /// 给你一个 无重复元素 的整数数组 candidates 和一个目标整数 target ，找出 candidates 中可以使数字和为目标数 target 的 所有 不同组合 ，并以列表形式返回。你可以按 任意顺序 返回这些组合。
    /// candidates 中的 同一个 数字可以 无限制重复被选取 。如果至少一个数字的被选数量不同，则两种组合是不同的。
    /// </summary>
    class Program
    {
        public static List<List<int>> ret = new List<List<int>>();
        public static List<int> tempRes = new List<int>();
        static void Main(string[] args)
        {
            int[] candidates = new int[] { 2, 3, 5 };
            CombinationSum(candidates, 8);
        }
        /// <summary>
        /// 递归回溯法。
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<IList<int>> CombinationSum(int[] candidates,int target)
        {
       
            Array.Sort(candidates);
            DFS(0, 0, candidates, target);
            return ret.ToArray();
        }
        /// <summary>
        /// 回溯+减枝
        /// </summary>
        public static void DFS(int cur,int sum,int[] candidates,int target)
        {
            if (sum == target)
            {
                // 不能使用ret.Add(tempRes);  直接Add是传递的tempRes的地址，数组是引用类型
                ret.Add(new List<int>(tempRes));
                return;
            }
            for(int i = cur; i < candidates.Length; i++)
            {
                if (sum + candidates[i] <= target)
                {
                    tempRes.Add(candidates[i]);
                    DFS(i, sum + candidates[i], candidates, target);
                    tempRes.RemoveAt(tempRes.Count - 1);// 回溯
                }
                else //因为已经排序，所以当当前i的和大于target后，就无须考虑后面的了。
                {
                    break;
                }
            }
        }
    }
}
