using System;

namespace Leet_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1,2,};
            int[] nums2 = new int[] { 3,4};
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
            

        }
        // O(m+n)
        //public static double FindMedianSortedArrays(int[] nums1,int[] nums2)
        //{
        //    int median = nums1.Length + nums2.Length;
        //    int left = 0, right = 0, idx = 0;
        //    int[] nums = new int[(nums1.Length + nums2.Length) / 2+1];
        //    while (idx < nums.Length)
        //    {
        //        if (left < nums1.Length && right < nums2.Length)
        //        {
        //            nums[idx++] = nums1[left] < nums2[right] ? nums1[left++] : nums2[right++];
        //        }
        //        else if (left >= nums1.Length)
        //        {
        //            nums[idx++] = nums2[right++];
        //        }
        //        else
        //        {
        //            nums[idx++] = nums1[left++];
        //        }
        //    }
        //    return median % 2 == 0 ? (double)(nums[nums.Length - 1] + nums[nums.Length - 2]) / 2 : (double)nums[nums.Length - 1];
        //}

        // O(log(m+n)
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int total = nums1.Length + nums2.Length;
            if (total % 2 != 0)
            {
                return getNumberOfK(nums1, nums2, total / 2 + 1);
            }
            else
            {
                return (getNumberOfK(nums1, nums2, total / 2) + getNumberOfK(nums1, nums2, total / 2 + 1))/2.0;
            }
        }
        public static int getNumberOfK(int[] nums1,int[] nums2,int k)
        {
            int length1 = nums1.Length, length2 = nums2.Length;
            int id1 = 0, id2 = 0;
            while (true)
            {
                if (id1 == length1)
                {
                    return nums2[id2 + k - 1];
                }
                if (id2 == length2)
                {
                    return nums1[id1 + k - 1];
                }
                if (k == 1)
                {
                    return Math.Min(nums1[id1], nums2[id2]);
                }
                // 正常情况
                int half = k / 2;
                // 双数组二分查找
                int newIndex1 = Math.Min(id1 + half, length1) - 1;
                int newIndex2 = Math.Min(id2 + half, length2) - 1;
                int pivot1 = nums1[newIndex1], pivot2 = nums2[newIndex2];
                if (pivot1 <= pivot2)
                {
                    k -= (newIndex1 - id1 + 1);
                    id1 = newIndex1 + 1;
                }
                else
                {
                    k -= (newIndex2 - id2 + 1);
                    id2 = newIndex2 + 1;
                }
            }
        }
    }
}
