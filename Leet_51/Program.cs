using System;
using System.Collections.Generic;


/// <summary>
/// 回顾这道题，拿到这道题的时候，其实我们很容易看出需要使用枚举的方法来求解这个问题，当我们不知道用什么办法来枚举是最优的时候，可以从下面三个方向考虑：

//子集枚举：可以把问题转化成「从 n^2n 
//2
//  个格子中选一个子集，使得子集中恰好有 nn 个格子，且任意选出两个都不在同行、同列或者同对角线」，这里枚举的规模是 2^{n^2}2
//n
//2
 
// ；
//组合枚举：可以把问题转化成「从 n^2n 
//2
//  个格子中选择 nn 个，且任意选出两个都不在同行、同列或者同对角线」，这里的枚举规模是 {n^2} 
/// </summary>
namespace Leet_51
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = SolveNQueens(4); 
        }
        public static IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> ret = new List<IList<string>>();
            var chs = new char[n][];
            for(int i = 0; i < n; i++)
            {
                chs[i] = new char[n];
            }
            // initial chs
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    chs[i][j] = '.';
                }
            }
            PutQueen(chs, 0, ret);
            return ret;
        }

        public static IList<string> CharToListString(char[][] chs)
        {
            var ret = new List<string>();
            for(int i = 0; i < chs.Length; i++)
            {
                ret.Add(new String(chs[i]));
            }
            return ret;
        } 

        public static void PutQueen(char[][] chs,int row, List<IList<string>> ret)
        {
            if(row == chs.Length)
            {
                ret.Add(CharToListString(chs));
                return;
            }
            for(int i = 0; i < chs.Length; i++)
            {
                if (IsValid(chs, i, row))
                {
                    chs[i][row] = 'Q';
                    PutQueen(chs, row + 1, ret);
                    chs[i][row] = '.';
                }
            }
        }

        /// <summary>
        /// 判断chs的k行l列放皇后是否合法，如果不在同一列并且
        /// </summary>
        /// <param name="chs"></param>
        /// <param name="j"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool IsValid(char[][] chs,int k,int l)
        {
            for(int i = 0; i < chs.Length; i++)
            {
                for(int j = 0; j < chs.Length; j++)
                {
                    if (chs[i][j] == 'Q' && (i == k || Math.Abs(i - k) == Math.Abs(j - l)))
                        return false;
                }
            }
            return true;
        }
    }
}
