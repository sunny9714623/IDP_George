using System;
using System.Threading;
using System.Threading.Tasks;

namespace Leet_08
{
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
