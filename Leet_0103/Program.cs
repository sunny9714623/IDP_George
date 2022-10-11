using System.Text;

namespace Leet_0103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// 函数
        /// </summary>
        /// <param name="S"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        //public string ReplaceSpaces(string S, int length)
        //{
        //    return S[..length].Replace(" ", "%20");
        //}

        // 字符串数组
        //public string ReplaceSpaces(string S, int length)
        //{
        //    var result = new char[length * 3];
        //    var index = 0;
        //    for (var i = 0; i < length; i++)
        //    {
        //        if (S[i] == ' ')
        //        {
        //            result[index++] = '%';
        //            result[index++] = '2';
        //            result[index++] = '0';
        //        }
        //        else
        //        {
        //            result[index++] = S[i];
        //        }
        //    }

        //    return new string(result, 0, index);
        //}

        // 遍历法
        public string ReplaceSpaces(string S, int length)
        {
                StringBuilder sb = new StringBuilder();
                for(var i = 0; i < length; i++)
                {
                    if (S[i] == ' ')
                    {
                        sb.Append("%20");
                    }
                    else
                    {
                        sb.Append(S[i]);
                    }
                }
                return sb.ToString();
        }
    }
}