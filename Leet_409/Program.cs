using System;

namespace Leet_409
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = LongestPalindrome("zeusnilemacaronimaisanitratetartinasiaminoracamelinsuez");
        }
        public static int LongestPalindrome(string s)
        {
            int totalLength = 0, jishu = 0;
            var charNums = new int[58];
            foreach (var ch in s)
            {
                charNums[ch - 'A']++;
            }
            foreach (var item in charNums)
            {
                if (item > 0)
                {
                    if (item % 2 != 0) jishu = 1;
                    totalLength += item / 2 * 2;
                }
            }
            return totalLength + jishu;
        }
    }
}
