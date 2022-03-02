using System;
/// <summary>
/// 给定一个 n × n 的二维矩阵 matrix 表示一个图像。请你将图像顺时针旋转 90 度。
/// 你必须在 原地 旋转图像，这意味着你需要直接修改输入的二维矩阵。请不要 使用另一个矩阵来旋转图像。
/// </summary>
namespace leet_48
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化多维数组
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };
            Rotate(matrix);
        }
        /// <summary>
        /// 矩阵先转置，然后镜面对称, 非常好理解，比起那些找规律
        /// </summary>
        /// <param name="matrix"></param>
        public static void Rotate(int[][] matrix)
        {
            // 先实现转置
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }
            // 然后镜面翻转
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix.Length / 2; j++)
                {
                    (matrix[i][j], matrix[i][matrix.Length - 1 - j]) = (matrix[i][matrix.Length - 1 - j], matrix[i][j]);
                }
            }
        }
    }
}
