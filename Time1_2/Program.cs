using System;
using System.Linq;
using static System.Console;
namespace Time1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = ReadLine();
            //string[] list = input.Split(new char[] { '=' });
            //string stringNum = list.LastOrDefault();
            //char[] chrNum = stringNum.ToCharArray();
            //stringNum = ReverseArray(chrNum);
            //Int32 num;
            //try
            //{
            //    num = Int32.Parse(stringNum);
            //}
            //catch(Exception)
            //{
            //    num = 0;
            //}
            //WriteLine(num);
            int x = 1534236469;
            WriteLine(Reverse(x));
        }

        public static string ReverseArray(char[] newStr)
        {
            int l = newStr.Length-1;
            char c;
            for(int i = 0; i < l; i++, l--)
            {
                c = newStr[i];
                newStr[i] = newStr[l];
                newStr[l] = c;
            }
            return new string(newStr);
        }

        //public static int Reverse(int x)
        //{
        //    bool flag = true;
        //    uint y;
        //    if (x < 0)
        //    {
        //        flag = false;
        //        y = (uint)(x * (-1));
        //    }
        //    else
        //    {
        //        y = (uint)x;
        //    }
        //    uint[] nums = new uint[20];
        //    long retNum = 0;
        //    int i = 0;
        //    uint div = 10;
        //    int sum = 1;
        //    do
        //    {
        //        nums[i] = y % div;
        //        y = y / div;
        //        i++;
        //    } while (y != 0);
        //    for(int j = i-1; j >= 0; j--)
        //    {
        //        retNum += nums[j] * sum;
        //        if (sum > int.MaxValue || sum < int.MinValue)
        //        {
        //            return 0;
        //        }
        //        sum *= 10;
        //    }
        //    if (retNum > int.MaxValue || retNum < int.MinValue)
        //    {
        //        retNum = 0;
        //    }
        //    if (!flag)
        //    {
        //        retNum = retNum * (-1);
        //    }
        //    return (int)retNum;
        //}

        // 精简
        public static int Reverse(int x)
        {
            long result = 0;
            while (x != 0)
            {
                int temp = x % 10;
                result = result * 10 + temp;
                if (result > int.MaxValue || result < int.MinValue)
                {
                    return 0;
                }
                x = x / 10;
            }
            return (int)result;
        }
    }
}
