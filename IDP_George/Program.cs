using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace IDP_George
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            WriteLine(TwoSum(nums, target));
            // 进阶

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ret = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ret[0] = i;
                        ret[1] = j;
                        break;
                    }
                }
            }
            return ret;
        }
    }
}
