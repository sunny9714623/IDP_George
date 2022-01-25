using System;

namespace Leet_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string haystack = "hello", needle = "ll";
            int ret = StrStr(haystack, needle);
        }

        /// <summary>
        /// 双重循环，耗时
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public static int StrStr(string haystack,string needle)
        {
            if (needle == "")
            {
                return 0;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            for(int i = 0; i < haystack.Length; i++)
            {
                for(int j = 0,m=i; j < needle.Length && m < haystack.Length; j++,m++)
                {
                    if (haystack[m] != needle[j]) { break; }
                    if (j == needle.Length - 1) { return i; }
                }
            }
            return -1;
        }
    }
}
