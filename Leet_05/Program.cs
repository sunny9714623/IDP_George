using System;
using System.Collections.Generic;

namespace Leet_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cbbd";
            Console.WriteLine(LongestPlaindrome(s));
        }
        public static string LongestPlaindrome(string s)
        {
            int left = 0, right = 0;
            for(int i = 0; i < s.Length; i++)
            {
                extend(s, i, i,ref left,ref right);
                extend(s, i, i + 1, ref left, ref right);
            }
            return s.Substring(left, right-left+1);
        }
        // 两个指针，从中间往两边走，一边走一边扩展，如果相等就判断是否是长度满足。
        public static void extend(string s,int i,int j,ref int left,ref int right)
        {
            while (i >= 0 && j < s.Length && j - i + 1 <= s.Length && s[i] == s[j])
            {
                if (right - left < j - i)
                {
                    right = j;
                    left = i;
                }
                j++;
                i--;
            }
        }
    }
}
