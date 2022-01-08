using System;
using System.Collections.Generic;

namespace Leet_13
{
    /// <summary>
    /// 罗马数字转整数
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("LVIII"));
        }

        // 用时偏长，不太好。
        //public static int RomanToInt(string s)
        //{
        //    int ret = 0;
        //    int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        //    string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        //    for(int i = 0; i < roman.Length; i++)
        //    {
        //        while (s.StartsWith(roman[i]))
        //        {
        //            ret += values[i];
        //            s = s.Remove(0, roman[i].Length);
        //        }
        //    }
        //    return ret;
        //}

        //public static int RomanToInt(string s)
        //{
        //    int ret = 0;
        //    Dictionary<char, int> dic = new Dictionary<char, int>()
        //    {
        //        { 'I',1},
        //        {'V',5 },
        //        {'X',10 },
        //        {'L',50 },
        //        {'C',100 },
        //        {'D',500 },
        //        {'M',1000 },
        //    };
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (i < s.Length-1 &&dic[s[i]] < dic[s[i + 1]])
        //        {
        //            ret -= dic[s[i]];
        //        }
        //        else
        //        {
        //            ret += dic[s[i]];
        //        }
        //    }
        //    return ret;
        //}

        public static int RomanToInt(string s)
        {
            int ret = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && GetValueByChar(s[i]) < GetValueByChar(s[i+1]))
                {
                    ret -= GetValueByChar(s[i]);
                }
                else
                {
                    ret += GetValueByChar(s[i]);
                }
            }
            return ret;
        }
        public static int GetValueByChar(char s)
        {
            switch (s)
            {
                case 'I': return 1;
                case 'V':return 5;
                case 'X':return 10;
                case 'L':return 50;
                case 'C':return 100;
                case 'D':return 500;
                case 'M':return 1000;
            }
            return 0;
        }
    }
}
