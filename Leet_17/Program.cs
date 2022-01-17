using System;
using System.Collections;
using System.Collections.Generic;

namespace Leet_17
{
    /// <summary>
    /// 给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。答案可以按 任意顺序 返回。
    /// 给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LetterCombinations("23");
        }
        public static IList<string> LetterCombinations(string digits)
        {
           Dictionary<char, string> dic = new Dictionary<char, string> {
                { '2',"abc" },
                { '3',"def" },
                { '4',"ghi" },
                { '5',"jkl" },
                { '6',"mno" },
                { '7',"pqrs" },
                { '8',"tuv"},
                { '9',"wxyz" },
            };
            var ans = new List<string>();
            Backtrack(digits, dic, 0, ans, "");
            return ans;
        }
        public static void Backtrack(string digits, Dictionary<char, string> dic, int index,List<string> ls,string result)
        {
            if (index == digits.Length) //递归边界
            {
                if (result != "")
                {
                    ls.Add(result); //当字符串不为空时，返回
                }
                return;
            }
            foreach(var item in dic[digits[index]])
            {
                Backtrack(digits, dic, index + 1, ls, result + item);
            }
        }
    }
}
