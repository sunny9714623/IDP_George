namespace Leet_344
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void ReverseString(char[] s)
        {
            for(int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                (s[j], s[i]) = (s[i], s[j]);
            }
        }
    }
}