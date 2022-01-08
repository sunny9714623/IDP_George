using System;
using System.Collections.Generic;
using System.Linq;

namespace Leet_12
{
    /// <summary>
    /// 整数转罗马数字
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(1994));
        }

        /// 好像用时和内存比较多。
        //public static string IntToRoman(int num)
        //{
        //    Dictionary<int, string> dic = new Dictionary<int, string>() { };
        //    dic.Add(1, "I");
        //    dic.Add(4, "IV");
        //    dic.Add(5, "V");
        //    dic.Add(9, "IX");
        //    dic.Add(10, "X");
        //    dic.Add(40, "XL");
        //    dic.Add(50, "L");
        //    dic.Add(90, "XC");
        //    dic.Add(100, "C");
        //    dic.Add(400, "CD");
        //    dic.Add(500, "D");
        //    dic.Add(900, "CM");
        //    dic.Add(1000, "M");
        //    string s = "";
        //    for (int i = dic.Count - 1; i >= 0; i--)
        //    {
        //        while (num >= dic.ElementAt(i).Key)
        //        {
        //            s += dic.ElementAt(i).Value;
        //            num -= dic.ElementAt(i).Key;
        //        }
        //    }
        //    return s;
        //}

        /// <summary>
        /// 用时更短一些
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string IntToRoman(int num)
        {
            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string s = "";
            for(int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    s += roman[i];
                    num -= values[i];
                }
            }
            return s;
        }
    }
}
