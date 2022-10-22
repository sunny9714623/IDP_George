namespace Leet_443
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a','b','b','b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'c','c','c' };
            int ret = Compress(chars);
        }

        public static int Compress(char[] chars)
        {
            int n = chars.Length;
            int left = 0, write = 0;
            for (int read = 0; read < n; read++)
            {
                if(read == n-1 || chars[read] != chars[read + 1])
                {
                    chars[write++] = chars[read];
                    int num = read - left + 1;
                    if (num > 1)
                    {
                        int copyWrite = write;
                        while (num > 0)
                        {
                            chars[write++] = (char)(num % 10 + '0');
                            num /= 10;
                        }
                        Reverse(chars, copyWrite, write - 1);
                    }
                    left = read + 1;
                }
            }
            return write;
        }

        private static void Reverse(char[] chars, int left, int right)
        {
            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
        }
    }
}
