using System;
/// <summary>
/// 给你一个字符串 s，由若干单词组成，单词前后用一些空格字符隔开。返回字符串中 最后一个 单词的长度。
/// 单词 是指仅由字母组成、不包含任何空格字符的最大子字符串。
/// </summary>
namespace Leet_58
{
    class Program
    {
        static void Main(string[] args)
        {
            int ret = LengthOfLastWord("a");
        }
        //public static int LengthOfLastWord(string s)
        //{
        //    string[] ret;
        //    ret = s.Split(' ');
        //    for(int j = ret.Length - 1; j >= 0; j--)
        //    {
        //        if(ret[j]!="")
        //        {
        //            return ret[j].Length;
        //        }
        //    }
        //    return 0;
        //}

        public static int LengthOfLastWord(string s)
        {
            int index = s.Length - 1;
            while(s[index]==' ')
            {
                index--;
            }
            int len = 0;
            while(index >= 0 && s[index]!=' ')
            {
                len++;
                index--;
            }
            return len;
        }
    }
}
