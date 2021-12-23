using System;
using System.Collections.Generic;

namespace Leet_06
{
    class Program
    {
        /// <summary>
        /// 将一个给定字符串 s 根据给定的行数 numRows ，以从上往下、从左到右进行 N 字形排列。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(Convert("PAYPALISHIRING", 3));
        }
        public static string Convert(string s,int numRows)
        {
            if (numRows == 0)
            {
                return s;
            }
            string ret="";
            string[] rows = new string[numRows];
            char[] str = s.ToCharArray();
            int curRow = 0;
            bool down = false;
            foreach (char c in str)
            {
                if (curRow == 0 || curRow == numRows - 1)
                {
                    rows[curRow] += c;
                    down = !down;
                    curRow += down ? 1 : -1;
                }
                else
                {
                    rows[curRow] += c;
                    curRow += down ? 1 : -1;
                }
            }
            foreach(string ls in rows)
            {
                ret += ls;
            }
            return ret;
        }
    }
}
