using System.Text;

namespace Leet_0807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static List<string> ret = new List<string>();
        public string[] Permutation(string S)
        {
            // PermutationBuild("", S);
            bool[] isVisited = new bool[S.Length];
            TrackBack(S, isVisited, new StringBuilder());
            return ret.ToArray();
        }
        //private void PermutationBuild(string res,string s)
        //{
        //    if (s.Length == 0)
        //    {
        //        ret.Add(res);
        //        return;
        //    }
        //    for(int i = 0; i < s.Length; i++)
        //    {
        //        string newres = res + s[i];
        //        string m = s.Remove(i, 1);
        //        PermutationBuild(newres, m);
        //    }
        //}

        private void TrackBack(string s, bool[] isVisited, StringBuilder sb)
        {
            if (sb.Length == s.Length)
            {
                ret.Add(sb.ToString());
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!isVisited[i])
                {
                    sb.Append(s[i]);
                    isVisited[i] = true;
                    TrackBack(s, isVisited, sb);
                    sb.Remove(sb.Length - 1, 1);
                    isVisited[i] = false;
                }
            }
        }
    }
}