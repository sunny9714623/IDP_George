using System;
using System.Linq;

namespace Leet_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2 };
            int ret = RemoveElement(nums, 2);
        }
        /// <summary>
        /// 循环遍历数组，定义两个指针。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        //public static int RemoveElement(int[] nums, int val)
        //{
        //    if (nums == null)
        //    {
        //        return 0;
        //    }
        //    int preIndex = 0, currIndex = 0;
        //    while (currIndex < nums.Length)
        //    {
        //        if (nums[currIndex] != val) nums[preIndex++] = nums[currIndex];
        //        currIndex++;
        //    }
        //    return preIndex;
        //}

        /// 避免了需要保留的元素的重复赋值操作，并且只遍历数组一次, 实现上面方法的优化
        public static int RemoveElement(int[] nums,int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int preIndex = 0, currIndex = nums.Length - 1;
            while (preIndex <= currIndex)
            {
                if (nums[preIndex] == val)
                {
                    nums[preIndex] = nums[currIndex];
                    currIndex--;
                }
                else preIndex++;
            }
            return preIndex;
        }
        
    }
}
