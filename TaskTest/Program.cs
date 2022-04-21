using System;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestClass();
            Console.WriteLine("Current ThreadId:" + System.Environment.CurrentManagedThreadId);
            Console.WriteLine("test");
            TestClass.callMethod();
            //test.TestAsync();
            Console.WriteLine("test1");
            Console.ReadKey();
        }
    }

    public class TestClass
    {
        public void Test()
        {
            Console.WriteLine("begin:");
            Task.Run(() => { for (int i = 0; i < 100; i++) { Console.WriteLine("Current ThreadId:" + System.Environment.CurrentManagedThreadId); Console.WriteLine(i); } });
            Console.WriteLine("Current ThreadId:" + System.Environment.CurrentManagedThreadId);
            Console.WriteLine("end");
        }

        public async void TestAsync()
        {
            Console.WriteLine("Current ThreadId:"+System.Environment.CurrentManagedThreadId);
            Console.WriteLine("begin:");
            Task.Run(() => { for (int i = 0; i < 100; i++) { Console.WriteLine("Current ThreadId:"+System.Environment.CurrentManagedThreadId); Console.WriteLine(i); } });
            Console.WriteLine("Current ThreadId:" + System.Environment.CurrentManagedThreadId);
            Console.WriteLine("end");
        }

        public void TestWaitAsync()
        {
            Console.WriteLine("TestWaitAsync");
            Console.WriteLine("Current ThreadId:" + System.Environment.CurrentManagedThreadId);
            TestAsync();
            Console.WriteLine("TestWaitAsync ThreadId:" + System.Environment.CurrentManagedThreadId);
            Console.WriteLine("TestAsync completed");
        }
        public static async void callMethod()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            Console.WriteLine("before delay");
            await Task.Delay(2000);
            Console.WriteLine("afterdelay");
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
            Task.Delay(1000);
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }


}
