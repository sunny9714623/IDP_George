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
        public static string GetPermutation(int n,int k)
        {
            StringBuilder s = new StringBuilder();
            bool[] used = new bool[n+1];
            int[] factial = new int[n];
            factial[0] = 1;
            for (int i = 1; i < n; i++)
            {
                factial[i] = i * factial[i - 1];
            }
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
