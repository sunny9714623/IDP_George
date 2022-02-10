using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
/// 给定一个字符串 s 和一些 长度相同 的单词 words 。找出 s 中恰好可以由 words 中所有单词串联形成的子串的起始位置。
/// 注意子串要与 words 中的单词完全匹配，中间不能有其他字符 ，但不需要考虑 words 中单词串联的顺序。
namespace Leet_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "foo", "bar"};
            FindSubstring("barfoothefoobarman", words);
        }
        /// <summary>
        /// 单起点滑动窗口
        /// </summary>
        /// <param name="s"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        //public static IList<int> FindSubstring(string s,string[] words)
        //{
        //    List<int> res = new List<int>();
        //    // 使用Dictionary存储words中单词总数
        //    Dictionary<string, int> wordNumber = new Dictionary<string, int>();
        //    foreach(string word in words)
        //    {
        //        if (!wordNumber.ContainsKey(word))
        //        {
        //            wordNumber.Add(word, 0);
        //        }
        //        wordNumber[word]++;
        //    }
        //    for(int i = 0; i < s.Length - words[0].Length * words.Length + 1; i++)
        //    {
        //        Dictionary<string, int> searchWords = new Dictionary<string, int>();
        //        int num = 0;//当前单词.
        //        while (num < words.Length)
        //        {
        //            string word = s.Substring(i+num*words[0].Length,words[0].Length);
        //            if (wordNumber.ContainsKey(word))
        //            {
        //                if (searchWords.ContainsKey(word))
        //                {
        //                    if (wordNumber[word] == searchWords[word])
        //                    {
        //                        break;// s大于words中的数量
        //                    }
        //                    searchWords[word]++;
        //                }
        //                else
        //                {
        //                    searchWords.Add(word, 1);
        //                }
        //            }
        //            else
        //            {
        //                break;
        //            }
        //            num++;
        //        }
        //        if (num == words.Length)
        //        {
        //            res.Add(i);
        //        }
        //    }
        //    return res;
        //}

        /// <summary>
        /// 多起点滑动窗口
        /// </summary>
        /// <param name="s"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IList<int> FindSubstring(string s, string[] words)
        {
            List<int> res = new List<int>();
            // 使用Dictionary存储words中单词总数
            int n = s.Length, d = words[0].Length, len = d * words.Length;
            Dictionary<string, int> wordNumber = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!wordNumber.ContainsKey(word))
                {
                    wordNumber.Add(word, 0);
                }
                wordNumber[word]++;
            }
            // 初始化0~d-1滑动窗口对应的词频统计表
            Dictionary<string, int>[] diffirentS = new Dictionary<string, int>[d];
            for(int i = 0; i < d && i + len <= n; i++)
            {
                diffirentS[i] = new Dictionary<string, int>();
                for(int j = i; j < i + len; j += d)
                {
                    string w = s.Substring(j,d);
                    if (!diffirentS[i].ContainsKey(w))
                    {
                        diffirentS[i].Add(w, 0);
                    }
                    diffirentS[i][w]++;
                }
                if (EqualsWith(diffirentS[i],wordNumber))
                {
                    res.Add(i);
                }
            }
            for(int i = d; i + len <= n; i++)
            {
                int r = i % d;
                // wa出窗字符串，wb入窗字符串
                string wa = s.Substring(i - d, d), wb = s.Substring(i + len - d, d);
                if (diffirentS[r].ContainsKey(wa))
                {
                    diffirentS[r][wa]--;
                    if (diffirentS[r][wa] == 0)
                    {
                        diffirentS[r].Remove(wa);
                    }
                }
                if (!diffirentS[r].ContainsKey(wb))
                {
                    diffirentS[r].Add(wb, 0);
                }
                diffirentS[r][wb]++;
                if (EqualsWith(diffirentS[r],wordNumber)) res.Add(i);
            }
            return res;
        }
        public static bool EqualsWith(Dictionary<string,int> DA, Dictionary<string, int> DB)
        {
            if (DA.Count != DB.Count)
            {
                return false;
            }
            foreach(var Akey in DA.Keys)
            {
                if (!DB.ContainsKey(Akey))
                {
                    return false;
                }
                else if (DA[Akey] != DB[Akey])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
