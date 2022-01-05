using System;
using System.Threading;
using System.Threading.Tasks;

namespace Leet_08
{
    /// <summary>
    /// 请你来实现一个 myAtoi(string s) 函数，使其能将字符串转换成一个 32 位有符号整数（类似 C/C++ 中的 atoi 函数）。
    ///   函数 myAtoi(string s) 的算法如下：
    /// 读入字符串并丢弃无用的前导空格
    /// 检查下一个字符（假设还未到字符末尾）为正还是负号，读取该字符（如果有）。 确定最终结果是负数还是正数。 如果两者都不存在，则假定结果为正。
    /// 读入下一个字符，直到到达下一个非数字字符或到达输入的结尾。字符串的其余部分将被忽略。
    /// 将前面步骤读入的这些数字转换为整数（即，"123" -> 123， "0032" -> 32）。如果没有读入数字，则整数为 0 。必要时更改符号（从步骤 2 开始）。
    /// 如果整数数超过 32 位有符号整数范围[−231, 231 − 1] ，需要截断这个整数，使其保持在这个范围内。具体来说，小于 −231 的整数应该被固定为 −231 ，大于 231 − 1 的整数应该被固定为 231 − 1 。
    /// 返回整数作为最终结果。
    /// 注意：
    /// 本题中的空白字符只包括空格字符 ' ' 。
    /// 除前导空格或数字后的其余字符串外，请勿忽略 任何其他字符。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Program();
            int result = test.MyAtoi("-2147483648");
            Console.WriteLine(result);
            test.GetTask2();
            Console.WriteLine("Main方法中:");
            result = test.MyAtoi("-216000000");
            Console.WriteLine(result);
            Console.WriteLine("在GetTaskCopy中");
            test.GetTaskCopy();
            Console.ReadKey();
        }

        public async void GetTask2()
        {
            Task<int> task = this.GetTask();
            int abc = await task;
            Console.WriteLine("GetTask2:结果是");
            Console.WriteLine(abc);
        }
        public async Task<int> GetTask()
        {
            int result = 0;
            Func<int> action = () =>
            {
                for (int i = 0; i < 100; i++)
                {
                    result += MyAtoi("-23");
                    Console.WriteLine(result);
                };
                return result;
            };
            await Task<int>.Run(action);
            //    () =>
            //{
            //    int num;
            //    for (int i = 0; i < 100; i++)
            //    {
            //        num = action("-23");
            //        result += num;
            //        Console.WriteLine(result);
            //    }
            //});
            return result;
        }

        public void GetTaskCopy()
        {
            for(int i = 0; i < 10; i++)
            {
                Action action = () => GetTotal();
                Task.Run(action);
            }
        }
        public void GetTotal()
        {
            int result = 0;
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} begin");
            for (int i = 0; i < 100; i++)
            {
                result += MyAtoi("-23");
            };
            Console.WriteLine($"{ Thread.CurrentThread.ManagedThreadId}end");
            Console.WriteLine(result);
        }
        public int MyAtoi(string s)
        {
            s = s.Trim();
            int i = 0;
            bool fu = false;
            string str=null;
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            if (s[i] == '-')
            {
                fu = true;
                i++;
            }
            else if (s[i] == '+')
            {
                fu = false;
                i++;
            }
            while (true)
            {
                if (i >= s.Length || s[i] < '0' || s[i] > '9')
                {
                    break;
                }
                str += s[i++];
            }
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            return fu ? double.Parse(str) * -1 <= (int.MinValue) ? int.MinValue : int.Parse(str) * -1 : double.Parse(str) > int.MaxValue ? int.MaxValue : int.Parse(str);
        }
    }
}
