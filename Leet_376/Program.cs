using System;

namespace Leet_376
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,2,3,4,5,6,7 };
            int ret = WiggleMaxLength(nums);
        }

        /// <summary>
        /// 动态规划
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        //public static int WiggleMaxLength(int[] nums)
        //{
        //    int down = 1, up = 1;
        //    for(int i = 1; i < nums.Length; i++)
        //    {
        //        if (nums[i] > nums[i - 1])
        //        {
        //            up = down + 1;
        //        }
        //        if (nums[i] < nums[i - 1])
        //        {
        //            down = up + 1;
        //        }
        //    }
        //    return nums.Length > 0 ? Math.Max(down, up) : 0;
        //}


        /// <summary>
        /// 贪心
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public static int WiggleMaxLength(int[] nums)
        {
            int preSub = 0, curSub = 0, count = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                curSub = nums[i] - nums[i - 1];
                if ((curSub > 0 && preSub <= 0) || (curSub < 0 && preSub >= 0))
                {
                    count++;
                    preSub = curSub;
                }
            }
            return nums.Length > 0 ? count : 0;
        }
    }
}
