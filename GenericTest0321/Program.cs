using System;

namespace GenericTest0321
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();
            Console.WriteLine(test.WriteToConsole(1));
            Console.WriteLine(test.WriteToConsole("asd"));
            Console.WriteLine("*********");
            Console.WriteLine(test.WriteToConsole<int>(1));
            Console.WriteLine(test.WriteToConsole<string>("dasdsa"));
        }

    }
    public class Test
    {
        public string WriteToConsole<T>(T t)
        {
            return (t.GetType().ToString());
        }
    }
}
