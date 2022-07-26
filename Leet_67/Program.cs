using System;
using System.Linq;
using System.Text;

namespace Leet_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1010";
            string b = "11011";
            var ret = AddBinary(a, b);
        }

        /// <summary>
        /// 模拟，然后再逆序输出
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string AddBinary(string a, string b)
        {
            if (a == null || b == null)
            {
                return a ?? b;
            }
            StringBuilder sb = new StringBuilder();
            int i = 0;
            int add = 0;
            while(i<a.Length || i < b.Length)
            {
                add += i < a.Length ? a[a.Length - 1 - i] - '0' : 0;
                add += i < b.Length ? b[b.Length - 1 - i] - '0' : 0;
                sb.Append(add % 2);
                add /= 2;
                i++;
            }
            if(add > 0)
            {
                sb.Append(1);
            }
            char[] charArray = sb.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }
    }
}
