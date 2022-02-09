﻿using System;

namespace Leet_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Divide(7,-3);
        }
        /// <summary>
        /// 不让用乘除法，其实除法本质就是减法。这里使用左移右移替代减法
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static int Divide(int dividend,int divisor)
        {
            // 这里进行判断。
            // 使用异或判断是否为负数，负数异或正数结果还是负数。
            bool negetive = (dividend ^ divisor) < 0;
            if (dividend == int.MinValue)
            {
                if (divisor == -1) //这里溢出
                {
                    return int.MaxValue;
                }
                if (divisor == 1)
                {
                    return int.MinValue;
                }
            }
            if (divisor == int.MinValue)
            {
                return dividend == divisor ? 1 : 0;
            }
            // 全部转为负数，防止溢出。操作方式一样。
            dividend = dividend < 0 ? dividend : -dividend;
            divisor = divisor < 0 ? divisor : -divisor;
            int ans = 0;
            while (dividend - divisor <= 0)
            {
                // 这里每次都要从新开始
                int divisor2 = divisor, test = 1;
                while (divisor2>=dividend-divisor2)
                {
                    divisor2 = divisor2 << 1;
                    test = test << 1;
                }
                dividend -= divisor2;
                ans += test;
            }
            return negetive ? -ans : ans;
        }
    }
}
