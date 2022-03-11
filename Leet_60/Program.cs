using System;
using System.Text;
/// <summary>
/// 给出集合 [1,2,3,...,n]，其所有元素共有 n! 种排列。
/// 按大小顺序列出所有排列情况，并一一标记，当 n = 3 时, 所有排列如下：
/// "123"
/// "132"
/// "213"
/// "231"
/// "312"
/// "321"
/// 给定 n 和 k，返回第 k 个排列。
/// </summary>

namespace Leet_60
{
    class Program
    {
        static void Main(string[] args)
        {
            string ret = GetPermutation(1, 1);
        }
        /// <summary>
        /// 1 想法1：计算出(1,n)的所有全排列，再选取第K个（超时） 
        /// 2 想法2：既然所有的全排列是从小到大，那么可以对每一位的数字进行定位。
        /// 例如，假如给定题目为（5,46）。固定第一位数，后面4位的全排列数为24，math.ceil(46/24)=2,
        /// 即处于第1位数的第二个循环中，即第一位数为2.同理，对于固定第二位数，math.ceil(（46-24）/6)=4,
        /// 即处于第2位数的第四个循环中（此时列表移除了已确定的数字2），即第2位数为5.
        /// 同理，可依次推理出最后结果为“25341”.总复杂度为O（n）.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string GetPermutation(int n,int k)
        {
            StringBuilder s = new StringBuilder();
            bool[] used = new bool[n + 1];// 标记数组，表示当前数组是否使用。
            int[] factial = new int[n];
            factial[0] = 1;
            for (int i = 1; i < n; i++)
            {
                factial[i] = i * factial[i - 1];
            }// 计算n!的值
            for(int i = 0; i < n; i++)
            {
                // 查找是当前循环第几个数。
                int m = (k - 1) / factial[n - i - 1] + 1;
                int count = 1;
                for(int j = 1; j <= n; j++)
                {
                    if (used[j]) continue;
                    if (!used[j] && count == m)
                    {
                        s.Append(j);
                        used[j] = true;
                        break;
                    }
                    count++;
                }
                // k减去已经算进去的
                k -= (m - 1) * factial[n - i - 1];
            }
            return s.ToString();
        }

        //public static int GetFactorial(int n,int[] factrial)
        //{
        //    if (n == 0)
        //        return 1;
        //    factrial[n] = n * GetFactorial(n - 1,factrial);
        //    return factrial[n];
        //}
    }
}
