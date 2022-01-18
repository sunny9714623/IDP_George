using System;
using System.Collections;

namespace Leet_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("[]"));
        }

        /// <summary>
        /// 利用栈
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //public static bool IsValid(string s)
        //{
        //    Stack st = new Stack();
        //    foreach(var item in s)
        //    {
        //        switch (item)
        //        {
        //            case '(':st.Push(item);break;
        //            case '{':st.Push(item);break;
        //            case '[':st.Push(item);break;
        //            case ')':  if (st.Count != 0 && (char)st.Pop() == '(') { break; }
        //                else { return false; }
        //            case ']':
        //                if (st.Count != 0 && (char)st.Pop() == '[') { break; }
        //                else { return false; }
        //            case '}':
        //                if (st.Count != 0 && (char)st.Pop() == '{') { break; }
        //                else { return false; }
        //        }
        //    }
        //    if (st != 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public static bool IsValid(string s)
        {
            // 如果都是成对，最终会变成空字符串。
            while (s.Contains("{}") || s.Contains("[]") || s.Contains("()"))
            {
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
                s = s.Replace("()", "");
            }
            return s == "";
        } 
    }
}
