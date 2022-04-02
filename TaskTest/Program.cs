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
            test.TestAsync();
            Console.WriteLine("test1");
        }
    }

    public class TestClass
    {
        public void Test()
        {
            Console.WriteLine("begin:");
            Task.Run(() => { for (int i = 0; i < 100; i++) { Console.WriteLine("Current ThreadId:" + System.Environment.CurrentManagedThreadId); Console.WriteLine(i); } });
            Console.WriteLine("end");
        }

        public async Task TestAsync()
        {
            Console.WriteLine("Current ThreadId:"+System.Environment.CurrentManagedThreadId);
            Console.WriteLine("begin:");
            await Task.Run(() => { for (int i = 0; i < 100; i++) { Console.WriteLine("Current ThreadId:"+System.Environment.CurrentManagedThreadId); Console.WriteLine(i); } });
            Console.WriteLine("end");
        }

        public async Task TestWaitAsync()
        {
            Console.WriteLine("TestWaitAsync");
            Console.WriteLine("Current ThreadId:" + System.Environment.CurrentManagedThreadId);
            await TestAsync();
        }

    }
}
