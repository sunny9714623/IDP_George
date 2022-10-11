using System.Text;

namespace Leet_0808
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private List<string> ret = new List<string>();
        public string[] Permutation(string S)
        {
            char[] chars = S.ToCharArray();
            Array.Sort(chars);
            bool[] isVisited = new bool[chars.Length];
            TrackBack(chars, isVisited, new StringBuilder());
            return ret.ToArray();
        }

        private void TrackBack(char[] s, bool[] isVisited, StringBuilder sb)
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

                    while (i + 1 < s.Length && s[i] == s[i+1])
                        i++;
                }
            }
        }
    }
}