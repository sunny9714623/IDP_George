using System;
/// <summary>
/// 请你判断一个 9 x 9 的数独是否有效。只需要 根据以下规则 ，验证已经填入的数字是否有效即可。
/// 数字 1 - 9 在每一行只能出现一次。
/// 数字 1 - 9 在每一列只能出现一次。
/// 数字 1 - 9 在每一个以粗实线分隔的 3x3 宫内只能出现一次。（请参考示例图）
/// </summary>
namespace Leet_36
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[9, 9] {
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            { '5', '3', '.', '.', '7', '.', '.', '.', '.' }
            };
        }
        public static bool IsValidSudoku(char[][] board)
        {
            // 遍历表盘，如果某行，某列，某个9方格区域有相同时。
            // 默认为0
            int[,] rows = new int[9,9];
            int[,] columns = new int[9, 9];
            int[,,] tables = new int[3, 3, 9];
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    char c = board[i][j];
                    if (c != '.')
                    {
                        int index = c - '0' - 1;
                        rows[i, index]++;
                        columns[j, index]++;
                        tables[i / 3, j / 3, index]++;
                        if (rows[i, index] > 1 || columns[j, index] > 1 || tables[i / 3, j / 3, index] > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
