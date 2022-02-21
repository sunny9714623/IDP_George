using System;

namespace Leet_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int ret = Trap(height);
        }
        public static int Trap(int[] height)
        {
            int ans = 0;
            for(int i = 0; i < height.Length - 1; i++)
            {
                int leftmax = 0, rightmax = 0;
                for (int j = i; j < height.Length; j++)
                {
                    rightmax = Math.Max(rightmax, height[j]);
                }
                for(int j = i; j >= 0; j--)
                {
                    leftmax = Math.Max(leftmax, height[j]);
                }
                ans += Math.Min(leftmax, rightmax) - height[i];
            }
            return ans;
        }
    }
}
