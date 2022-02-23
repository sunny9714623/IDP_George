using System;
using System.Text;

namespace Leet_415
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = AddStrings("0", "123");
        }

        /// <summary>
        /// 从后往前遍历，然后对每个字符进行进位加减
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string AddStrings(string num1,string num2)
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
    }
}
