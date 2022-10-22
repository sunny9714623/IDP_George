namespace Leet_324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 3 };
            WiggleSort(nums);
        }

        /// <summary>
        /// 排序加双指针，这里注意要将其逆序
        /// </summary>
        /// <param name="nums"></param>

        //public static void WiggleSort(int[] nums)
        //{
        //    Array.Sort(nums);
        //    int[] temp = (int[])nums.Clone();
        //    int left = (nums.Length - 1) / 2, right = nums.Length - 1;
        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            nums[i] = temp[left--];
        //        }
        //        else
        //        {
        //            nums[i] = temp[right--];
        //        }
        //    }
        //}

        public static void WiggleSort(int[] nums)
        {
            int[] bucket = new int[5001];
            foreach (int i in nums)
            {
                bucket[i]++;
            }
            int j = 5000;
            //先插入大的，每次间隔1
            for(int i = 1; i < nums.Length; i+=2)
            {
                while (bucket[j] == 0) j--;
                nums[i] = j;
                bucket[j]--;
            }
            for(int i = 0; i < nums.Length; i += 2)
            {
                while (bucket[j] == 0) j--;
                nums[i] = j;
                bucket[j]--;
            }
        }
    }
}