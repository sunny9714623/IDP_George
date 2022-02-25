using System;
using System.Text;
/// <summary>
/// 给定两个以字符串形式表示的非负整数 num1 和 num2，返回 num1 和 num2 的乘积，它们的乘积也表示为字符串形式。
/// 注意：不能使用任何内置的 BigInteger 库或直接将输入转换为整数。
/// </summary>
namespace Leet_43
{
    class Program
    {
        static void Main(string[] args)
        {
            string ret = Multiply("123", "456");
        }
        /// <summary>
        /// 对num2的每一位分别乘以num1,使用累加法
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        //public static string Multiply(string num1,string num2)
        //{
        //    string ans = "0";
        //    int len1 = num1.Length, len2 = num2.Length;
        //    if (num1.Equals("0") || num2.Equals("0"))
        //    {
        //        return "0";
        //    }
        //    for (int i = len2 - 1; i >= 0; i--)
        //    {
        //        StringBuilder s = new StringBuilder();
        //        int n2 = num2[i] - '0';
        //        if (n2 == '0')
        //        {
        //            continue;
        //        }
        //        int add = 0;
        //        int j = len1 - 1;
        //        while (add != 0 || j >= 0)
        //        {
        //            int n1 = j >= 0 ? num1[j--] - '0' : 0;
        //            add += n1 * n2;
        //            s.Insert(0, add % 10); // 在首位添加
        //            add /= 10;
        //        }
        //        s.Append('0', len2 - 1 - i);
        //        ans = AddStrings(ans, s.ToString());
        //    }
        //    return ans;
        //}

        public static string AddStrings(string num1, string num2)
        {
            if (num1.Equals("0") || num2.Equals("0"))
            {
                return num1.Equals("0") ? num2 : num1;
            }
            StringBuilder s = new StringBuilder();
            int i = num1.Length - 1, j = num2.Length - 1, add = 0;
            while (i >= 0 || j >= 0 || add > 0)
            {
                add += i >= 0 ? num1[i--] - '0' : 0;
                add += j >= 0 ? num2[j--] - '0' : 0;
                s.Insert(0, add % 10);
                add = add / 10;
            }
            return s.ToString();
        }

        /// <summary>
        /// 优化竖式相加版，对于num1[i]*num2[j]，结果一定为两位数
        /// 高位补0，那么可以高位一定在[i+j],地位一定在[i+j+1]
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        //public static string Multiply(string num1, string num2)
        //{
        //    if (num1.Equals("0") || num2.Equals("0"))
        //    {
        //        return "0";
        //    }
        //    int[] ans = new int[num1.Length + num2.Length];
        //    int n1 = num1.Length, n2 = num2.Length;
        //    int numn1 = 0, numn2 = 0;
        //    for (int i = n1 - 1; i >= 0; i--)
        //    {
        //        for (int j = n2 - 1; j >= 0; j--)
        //        {
        //            numn1 = num1[i] - '0';
        //            numn2 = num2[j] - '0';//因为从地位向高位计算，所以总和要加上这次地位，上次的高位。
        //            int sum = ans[i + j + 1] + numn1 * numn2;
        //            ans[i + j] += sum / 10; // 高位可能在下次计算中参与进位,这里不判断是否进位，因为在下一次计算时会进行判断。
        //            ans[i + j + 1] = sum % 10;
        //        }
        //    }
        //    StringBuilder s = new StringBuilder();
        //    for(int i = 0; i < ans.Length; i++)
        //    {
        //        if (ans[i] == 0 && i == 0) continue;
        //        s.Append(ans[i]);
        //    }
        //    return s.ToString();
        //}

        /// 这个方法可以先不考虑进位，直接放在相应的数组里
        public static string Multiply(string num1, string num2)
        {
            if (num1.Equals("0") || num2.Equals("0"))
            {
                return "0";
            }
            int[] ans = new int[num1.Length + num2.Length];
            int n1 = num1.Length, n2 = num2.Length;
            for (int i = n1 - 1; i >= 0; i--)
            {
                for (int j = n2 - 1; j >= 0; j--)
                {

                    ans[i + j + 1] += (num1[i] - '0') * (num2[j] - '0');
                }
            }
            StringBuilder s = new StringBuilder();
            int add = 0;
            // 按照存储的数字计算进位。
            for (int i = ans.Length-1; i >= 0; i--)
            {
                int sum = add + ans[i];
                ans[i] = sum % 10;
                add = sum / 10; 
            }
            for(int i = 0; i < ans.Length; i++)
            {
                if (ans[i] == 0 && i == 0) continue;
                s.Append(ans[i]);
            }
            return s.ToString();
        }
    }
}
