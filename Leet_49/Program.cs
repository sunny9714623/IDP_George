using System;
using System.Collections.Generic;
/// <summary>
/// 给你一个字符串数组，请你将 字母异位词 组合在一起。可以按任意顺序返回结果列表。
/// 字母异位词 是由重新排列源单词的字母得到的一个新单词，所有源单词中的字母通常恰好只用一次。
/// 输入: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
/// 输出:[["bat"],["nat","tan"],["ate","eat","tea"]]
/// </summary>
namespace Leet_49
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strs1 = new List<string>() { "eat", "tea", "tan", "ate", "nat", "bat" };
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var ret = GroupAnagrams(strs);
        }
        /// <summary>
        /// 简单思路：使用hash映射，key为每个单词字母排序后的字符串，value为List数组
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> _Anagrams = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                char[] arrar = str.ToCharArray();
                Array.Sort(arrar);
                string keys = new string(arrar);
                if (_Anagrams.ContainsKey(keys)) _Anagrams[keys].Add(str);
                else _Anagrams.Add(keys, new List<string> { str });
            }
            Console.WriteLine((_Anagrams.Values.GetType()));
            return new List<List<string>>(_Anagrams.Values).ToArray();
        }
    }
}
