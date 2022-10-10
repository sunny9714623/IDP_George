using System.Text;

namespace Leet_179
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static string LargestNumber(int[] nums)
        {
            Array.Sort(nums, (a, b) => (a + "" + b).CompareTo(b + "" + a));

            StringBuilder sb = new StringBuilder();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                sb.Append(nums[i].ToString());
            }
            if (sb.ToString().StartsWith("0")) return "0";
            return sb.ToString(); 
        }
    }
}