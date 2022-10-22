namespace Leet_240
{
    internal class Program
    {

        public const int A = 1;
        static void Main(string[] args)
        {

            Nullable<int> d1 = new Nullable<int>();
            Console.WriteLine(d1 == null);
            string str1 = null;
            string str2 = "";
            Shape circle = new Circle();
            circle.Method();
            //int[][] matrix = new int[][] { new int[] { 1, 4, 7, 11, 15 }, new int[] { 2, 5, 8, 12, 19 }, new int[] { 3, 6, 9, 16, 22 }, new int[] { 10, 13, 14, 17, 24 } };
            //var result = SearchMatrix(matrix, 171);

        }

        public class Shape
        {
            public virtual void Method()
            {
                Console.WriteLine("Shape Method.");
            }
        }

        public class Circle : Shape
        {
            public override void Method()
            {
                Console.WriteLine("Circle Method");
            }
        }
        //public static bool SearchMatrix(int[][] matrix, int target)
        //{
        //    foreach (var item in matrix)
        //    {
        //        if(BinarrySearch(item,target) > -1)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}


        /// <summary>
        /// 使用Z字形搜索，从（x,y和 martrx的左下角）
        /// 数组从左到右和从上到下都是升序的，如果从右上角出发开始遍历呢？
        /// 会发现每次都是向左数字会变小，向下数字会变大，有点和二分查找树相似。二分查找树的话，是向左数字变小，向右数字变大。
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int x = 0, y = matrix[0].Length - 1;
            while(x<matrix.Length && y >= 0)
            {
                if (matrix[x][y] == target)
                {
                    return true;
                }
                else if (matrix[x][y] > target)
                {
                    y--;
                }
                else
                {
                    x++;
                }
            }
            return false;
        }

        private static int BinarrySearch(int[] nums,int target)
        {
            int low = 0, high = nums.Length - 1;
            while(low <= high)
            {
                int mid = low + ((high - low) >> 1);
                if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}