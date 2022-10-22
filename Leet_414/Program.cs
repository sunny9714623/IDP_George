namespace Leet_414
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,1,int.MinValue };
            int result = ThirdMax(nums);
        }

        /// <summary>
        /// Set去重+排序
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public static int ThirdMax(int[] nums)
        //{
        //    SortedSet<int> ss = new SortedSet<int>();
        //    foreach(var num in nums)
        //    {
        //        ss.Add(num);
        //    }
        //    List<int> list = new List<int>(ss);
        //    return list.Count > 2 ? list[list.Count - 3] : list[list.Count - 1];
        //}


        // 定义三个数a,b,c分别带表最大值，次大值，次次大值
        public static int ThirdMax(int[] nums)
        {
            long a = long.MinValue, b = long.MinValue, c = long.MinValue;
            foreach(int num in nums){
                if (num > a)
                {
                    c = b;
                    b = a;
                    a = num;
                }
                else if( num > b && num < a)
                {
                    c = b;
                    b = num;
                }
                else if(num > c && num < b)
                {
                    c = num;
                }
            }
            return c == long.MinValue ? (int)a : (int)c;
        }
    }
}