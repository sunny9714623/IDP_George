using System;
using System.Collections.Generic;

namespace Leet_51
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static IList<IList<string>> SolveNQueens(int n)
        {
            List<List<string>> ret = new List<List<string>>();
            var chs = new char[n, n];
            // initial chs
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    chs[i, j] = '.';
                }
            }
            return null;
        }

        /// <summary>
        /// 判断chs的i行j列放皇后是否合法，如果不在同一列并且
        /// </summary>
        /// <param name="chs"></param>
        /// <param name="j"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool IsValid(char[,] chs,int k,int l)
        {
            for(int i = 0; i < chs.Length; i++)
            {
                for(int j = 0; j < chs.Length; j++)
                {

                }
            }
            return true;
        }
    }
}
