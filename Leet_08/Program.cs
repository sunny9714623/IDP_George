using System;

namespace Leet_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MyAtoi("-2147483648");
            Console.WriteLine(result);
        }

        public static int MyAtoi(string s)
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
