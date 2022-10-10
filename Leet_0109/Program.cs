namespace Leet_0109
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool IsFlipedString(string s1, string s2)
        {
            return s1.Length == s2.Length && (s1 + s1).Contains(s2);
        }
    }
}