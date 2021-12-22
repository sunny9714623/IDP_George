using System;

namespace Leet_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 1 };
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }
        // O(m+n)
        public static double FindMedianSortedArrays(int[] nums1,int[] nums2)
        {
            int median = nums1.Length + nums2.Length;
            int left = 0, right = 0, idx = 0;
            int[] nums = new int[(nums1.Length + nums2.Length) / 2+1];
            while (idx < nums.Length)
            {
                if (left < nums1.Length && right < nums2.Length)
                {
                    nums[idx++] = nums1[left] < nums2[right] ? nums1[left++] : nums2[right++];
                }
                else if (left >= nums1.Length)
                {
                    nums[idx++] = nums2[right++];
                }
                else
                {
                    nums[idx++] = nums1[left++];
                }
            }
            return median % 2 == 0 ? (double)(nums[nums.Length - 1] + nums[nums.Length - 2]) / 2 : (double)nums[nums.Length - 1];
        }

        // O(log(m+n)
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

        }
        public int getNumberOfK(int[] nums1,int[] nums2,int k)
        {
            int length1 = nums1.Length, length2 = nums2.Length;
            int half = k / 2;
            if (length1 == 0)
            {
                return nums2[k];
            }
            if (length2 == 0)
            {
                return nums1[k];
            }
            while (true)
            {

            }
        }
    }
}
