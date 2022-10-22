namespace Leet_491
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 6, 7, 7 };
            var list =  FindSubsequences(nums);
        }

        static IList<IList<int>> list = new List<IList<int>>();
        static IList<int> temp = new List<int>();
        public static IList<IList<int>> FindSubsequences(int[] nums)
        {
            DFS(0, nums, int.MinValue);
            return list;
        }   

        public static void DFS(int cur, int[] nums,int last)
        {
            if (cur == nums.Length)
            {
                if (temp.Count >= 2)
                {
                    list.Add(new List<int>(temp));
                }
                return;
            }
            // 这里是选择的逻辑，大于等于会选择连续两个一样的。当这里选择两个一样的时。
            if (nums[cur] >= last)
            {
                temp.Add(nums[cur]);
                DFS(cur + 1, nums, nums[cur]);
                temp.RemoveAt(temp.Count - 1);
            }
            // 对于两个相同元素
            // 前者被选择，后者被选择
            //前者被选择，后者不被选择
            //前者不被选择，后者被选择
            //前者不被选择，后者不被选择
            // 二三种等价，这样设计不选择后，舍弃了第二种
            if (nums[cur] != last)
            {
                DFS(cur + 1, nums, last);
            }
        }
    }
}