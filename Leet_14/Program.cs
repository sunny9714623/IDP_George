using System;

namespace Leet_14
{
    /// <summary>
    /// 编写一个函数来查找字符串数组中的最长公共前缀。
    /// 如果不存在公共前缀，返回空字符串 ""。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "flower", "flow", "flight" };
            string s = LongestCommonPrefix(strs);
            Console.WriteLine(s);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string s = "";
            int i = 0;
            while (i < strs[0].Length)
            {
                s += strs[0][i];
                foreach (string str in strs)
                {
                    if (!str.StartsWith(s))
                    {
                        s = s.Remove(s.Length - 1);
                        return s;
                    }
                }
                i++;
            }
            return s;
        }
    }
}
