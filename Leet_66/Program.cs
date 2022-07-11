using System;
///给定一个由 整数 组成的 非空 数组所表示的非负整数，在该数的基础上加一。

//最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。

//你可以假设除了整数 0 之外，这个整数不会以零开头。

namespace Leet_66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 9, 9, 9, 9, 9 };
            var res = PlusOne(test);
        }
        public static int[] PlusOne(int[] digits)
        {
            for(int i = digits.Length -1; i >= 0 ; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    continue;
                }
                digits[i] += 1;
                return digits;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
