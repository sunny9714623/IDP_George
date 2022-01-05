using System;

namespace Leet_09
{
    /// <summary>
    /// 给你一个整数 x ，如果 x 是一个回文整数，返回 true ；否则，返回 false 。
    /// 回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。例如，121 是回文，而 123 不是。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(10));
        }
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            if (x == Reverse(x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 利用整数反转
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            long result = 0;
            while (x != 0)
            {
                int temp = x % 10;
                result = result * 10 + temp;
                if (result > int.MaxValue || result < int.MinValue)
                {
                    return 0;
                }
                x = x / 10;
            }
            return (int)result;
        }

        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        //public static bool IsPalindrome(int x)
        //{
        //    if (x < 0)
        //    {
        //        return false;
        //    }
        //    string num = x.ToString();
        //    for(int i = 0, j = num.Length - 1; i <= j; i++, j--)
        //    {
        //        if (num[i] == num[j]) continue;
        //        return false;
        //    }
        //    return true;
        //}
    }
}
