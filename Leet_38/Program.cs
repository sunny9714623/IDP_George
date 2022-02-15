using System;
using System.Text;
/// <summary>
/// 给定一个正整数 n ，输出外观数列的第 n 项。
///「外观数列」是一个整数序列，从数字 1 开始，序列中的每一项都是对前一项的描述。
/// 你可以将其视作是由递归公式定义的数字字符串序列：
/// countAndSay(1) = "1"
/// countAndSay(n) 是对 countAndSay(n-1) 的描述，然后转换成另一个数字字符串。
/// </summary>
namespace Leet_38
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = CountAndSay(8);
        }
        //public static string CountAndSay(int n)
        //{
        //    return GetIndexstring("1",n);
        //}
        //public static string GetIndexstring(string ans,int n)
        //{
        //    StringBuilder str = new StringBuilder(); // 用stringbuilder加快速度，使用string的话速度慢，每次会new一个
        //    if (n == 1) // 统计n-1次
        //    {
        //        return ans;
        //    }
        //    else
        //    {
        //        char s = ans[0];
        //        int count = 0;
        //        foreach (var item in ans)
        //        {
        //            if(item == s)
        //            {
        //                count++;
        //            }
        //            else
        //            {
        //                str.Append(count.ToString());
        //                str.Append(s);
        //                s = item;
        //                count = 1;
        //            }
        //        }
        //        str.Append(count.ToString());
        //        str.Append(s);
        //    }
        //    return GetIndexstring(str.ToString(), n - 1);
        //}

        /// <summary>
        /// 效率没有那么高
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string CountAndSay(int n)
        {
            string str = "1";
            for(int i = 1; i < n; i++)
            {
                StringBuilder s = new StringBuilder();
                int start = 0, pos = 0;
                while (pos < str.Length)
                {
                    while(pos<str.Length && str[pos] == str[start])
                    {
                        pos++;
                    }
                    s.Append(pos - start).Append(str[start]);
                    start = pos;
                }
                str = s.ToString();
            }
            return str;
        }
    }
}
