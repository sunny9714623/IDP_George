namespace Leet_456
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 1, 4, 2 };
            var result = Find132pattern(nums);
        }
        public static bool Find132pattern(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int k = int.MinValue;
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] < k) return true;
                while(stack.Count!=0 && stack.Peek() < nums[i])
                {
                    k = Math.Max(k, stack.Pop());
                }
                stack.Push(nums[i]);
            }
            return false;
        }
    }
}