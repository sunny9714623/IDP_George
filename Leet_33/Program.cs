using System;

namespace Leet_33
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int Serch(int[] nums,int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
            }
            return -1;
        }
    }
}
