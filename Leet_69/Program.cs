using System;

namespace Leet_69
{
    class Program
    {
        static void Main(string[] args)
        {
            int ret = MySqrt(9);
        }

        /// <summary>
        /// 暴力解法
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        //public static int MySqrt(int x)
        //{
        //    if (x == 0 || x == 1) return x;
        //    long total = 1;
        //    while(total * total <= x)
        //    {
        //        total ++;
        //    }
        //    return (int)(total - 1);
        //}

        /// <summary>
        /// 二分解法，挺秒的
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt(int x)
        {
            if (x == 0 || x == 1) return x;
            int ret = 0;
            int l = 0, r = x;
            int mid;
            while (l <= r)
            {
                mid = (l + r) / 2;
                if (mid <= x / mid)
                {
                    ret = mid;
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return ret;
        }
    }
}
