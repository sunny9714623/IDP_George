using System;

namespace Time1_4
{
    /// <summary>
    /// 给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串 的长度。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = "pwwkew";
            Console.WriteLine(LengthOfLongestSubstring(s));
        }
        //public static int LengthOfLongestSubstring(string s)
        //{
        //    int max = 0;
        //    char[] str = s.ToCharArray();
        //    System.Collections.Generic.List<char> chin = new System.Collections.Generic.List<char>();
        //    foreach (char ch in str)
        //    {
        //        if (chin.Contains(ch))
        //        {
        //            max = max > chin.Count ? max : chin.Count;
        //            chin.Add(ch);
        //            chin = chin.GetRange(chin.IndexOf(ch) + 1, chin.Count - chin.IndexOf(ch) - 1);
        //        }
        //        else
        //        {
        //            chin.Add(ch);
        //        }
        //    }
        //    max = max > chin.Count ? max : chin.Count;
        //    return max;
        //}

        // 滑动窗口
        public static int LengthOfLongestSubstring (string s)
        {
            int left = 0, right = 0,max=0;
            System.Collections.Generic.List<char> chin = new System.Collections.Generic.List<char>();
            while (right < s.Length)
            {
                if (!chin.Contains(s[right]))
                {
                    chin.Add(s[right++]);
                }
                else
                {
                    chin.Remove(s[left++]);
                }
                max = max > right - left ? max : right - left ;
            }
            return max;
        }
    }
}
