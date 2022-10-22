namespace Leet367
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = IsPerfectSquare(16);
        }

        /// <summary>
        /// 二分查找，这里用除法，避免要使用long类型进行比较
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsPerfectSquare(int num)
        {
            int left = 1, right = num / 2 + 1;
            while(left <= right)
            {
                int mid = left + ((right - left) >> 1);
                int t = num / mid;
                if(t < mid)
                {
                    right = mid - 1;
                }
                else if(t > mid)
                {
                    left = mid + 1;
                }
                else
                    return num % mid == 0;
            }
            return false;
        }
    }
}