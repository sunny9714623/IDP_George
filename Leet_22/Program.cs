using System;
using System.Collections.Generic;

namespace Leet_22
{
    /// <summary>
    /// 数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ret = (List<string>)GenerateParenthesis(3);
        }
        public static List<string> ans = new List<string>();
        
        /// <summary>
        /// 使用DFS，left:左括号；right：右括号。
        /// </summary>
        /// <param name="path"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="n"></param>
        public static void DFS(string path,int left,int right,int n)
        {
            // 减枝，不需要再继续DFS
            if (left > n || right > left) return;
            if (path.Length == n * 2)
            {
                ans.Add(path);
                return;
            }
            DFS(path + "(", left + 1, right, n);
            DFS(path + ")", left, right + 1, n);
        }
        public static IList<string> GenerateParenthesis(int n)
        {
            if (n == 0) return ans;
            DFS("", 0, 0, n);
            return ans;
        }
    }
}

