namespace Leet_378
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class MyComparer : Comparer<int[]>
        {
            public override int Compare(int[]? x, int[]? y) => x[0] - y[0];
        }
        public static int KthSmallest(int[][] matrix, int k)
        {
            int n = matrix.Length;
            int left = matrix[0][0];
            int right = matrix[n - 1][n - 1];
            while (left < right)
            {
                int mid = left + ((right - left) >> 1); //这里left和right都是值，不是索引
                if (Check(matrix, mid, k))
                {
                    right = mid;
                }
                else
                    left = mid + 1;
            }
            return left;  //保证left在矩阵中，因为每次循环中都保证了第k小的数在left~right之间，当left==right时，第k小的数即被找出，等于left
        }

        private static bool Check(int[][] matrix,int mid, int k)
        {
            int i = matrix.Length - 1;
            int j = 0;
            int num = 0;
            while(i>=0 && j < matrix.Length)
            {
                if (matrix[i][j] <= mid)
                {
                    num += i + 1;
                    j++;
                }
                else
                    i--;
            }
            return num >= k;
        }
    }
}