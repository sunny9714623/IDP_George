using System;
using System.Collections.Generic;

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
