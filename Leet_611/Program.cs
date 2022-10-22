namespace Leet_611
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 2, 3, 4 };
            int result = TriangleNumber(nums);
        }

        //public static int TriangleNumber(int[] nums)
        //{
        //    int ans = 0;
        //    Array.Sort(nums);
        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        for(int j = i + 1; j < nums.Length; j++)
        //        {
        //            int sum = nums[i] + nums[j];
        //            int left = j + 1, right = nums.Length - 1;
        //            while (left <= right)
        //            {
        //                int mid = (left + right) / 2;
        //                if (nums[mid] < sum)
        //                {
        //                    left = mid + 1;
        //                }
        //                else
        //                {
        //                    right = mid - 1;
        //                }
        //            }
        //            ans += left - j - 1;  // 对于满足条件的直接无脑二分，直到不能二分，此时left是满足条件的最后一个
        //        }
        //    }
        //    return ans;
        //}

        /// <summary>
        /// 双指针，随着第二个数的增加，第三个数满足的范围也是增加的。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int TriangleNumber(int[] nums)
        {
            int ans = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int k = i;
                for(int j = i + 1; j < nums.Length; j++)
                {
                    while (k < nums.Length && nums[k] < nums[i] + nums[j])
                    {
                        k++;
                    }
                    ans += k - j - 1 > 0 ? k - j - 1 : 0;
                }
            }
            return ans;
        }

    }
}