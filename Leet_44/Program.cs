using System;
/// <summary>
/// 给定一个字符串 (s) 和一个字符模式 (p) ，实现一个支持 '?' 和 '*' 的通配符匹配。

/// '?' 可以匹配任何单个字符。
/// '*' 可以匹配任意字符串（包括空字符串）。
/// 两个字符串完全匹配才算匹配成功。
/// 说明:
/// s 可能为空，且只包含从 a-z 的小写字母。
/// p 可能为空，且只包含从 a-z 的小写字母，以及字符 ? 和 *。
/// </summary>
namespace Leet_44
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ret = IsMatch("adceb","*a*b");
        }
        public static bool IsMatch(string s,string p)
        {
            int sLenth = s.Length, pLenth = p.Length;
            bool[,] dp = new bool[sLenth + 1, pLenth + 1]; // +1 防止s或者p为空， 默认为false,
                                                           // dp[i][j]前i个字符和前j个字符能否匹配
            dp[0,0] = true;
            for(int j = 1; j <= pLenth; j++)
            {
                if (p[j-1] == '*')
                {
                    dp[0, j] = true;
                }
                else break;
            }
            for(int i = 1; i <= sLenth; i++)
            {
                for(int j = 1; j <= pLenth; j++)
                {
                    if (p[j - 1] == '?' || s[i - 1] == p[j - 1]) dp[i, j] = dp[i - 1, j - 1];
                    if (p[j - 1] == '*')
                        dp[i, j] = dp[i - 1, j] | dp[i, j - 1];
                    // dp[i-1,j]代表使用*，dp[i][j-1]代表不使用*
                }
            }
            return dp[sLenth, pLenth];
        }
    }
}
