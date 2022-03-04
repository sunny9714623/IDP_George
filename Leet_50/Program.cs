using System;
/// <summary>
/// 50. Pow(x, n)
/// </summary>
namespace Leet_50
{
    class Program
    {
        static void Main(string[] args)
        {
            double rt = MyPow(2.0, 10);
        }

        //public static double MyPow(double x,int n)
        //{
        //    double ans = 1;
        //    for(int i = n; i!=0; i/=2)
        //    {
        //        if (i % 2 != 0) { ans *= x; }
        //        x *= x;
        //    }
        //    return n > 0 ? ans : 1 / ans;
        //}

        /// <summary>
        /// 快速幂+递归,从后往前找规律，比如2^77次方可以看出2^38*2^38*2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double MyPow(double x, int n)
        {
            return n > 0 ? MutiPow(x, n) : 1 / MutiPow(x, n);
        }

        public static double MutiPow(double x,int n)
        {
            if (n == 0) return 1;
            double ret = MutiPow(x, n / 2);
            return n % 2 == 0 ? ret * ret : ret * ret * x;
        }
    }
}
