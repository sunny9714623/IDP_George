namespace Leet_13O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][] {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X','O','O','X'},
                new char[] { 'X','X','O','X'},
                new char[] { 'X','O','X','X'},
            };
            Solve(board);
        }

        public static void Solve(char[][] board)
        {
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[0].Length; j++)
                {
                    if ((i == 0 || j== 0 || i==board.Length-1 || j==board[0].Length-1) && board[i][j] == 'O')
                    {
                        DFS(board, i, j);
                    }
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X';
                    }
                    if (board[i][j] == '-')
                        board[i][j] = 'O';
                }
            }
        }

        /// <summary>
        /// 深度搜索，i,j为当前到的位置,对每个边界上的o做深度遍历，标记为‘-’
        /// 即另外一个值
        /// </summary>
        /// <param name="board"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void DFS(char[][] board,int i,int j)
        {
            if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || board[i][j] != 'O')
            {
                return;
            }
            board[i][j] = '-';
            DFS(board, i + 1, j);
            DFS(board, i - 1, j);
            DFS(board, i, j + 1);
            DFS(board, i, j - 1);
        }
    }
}