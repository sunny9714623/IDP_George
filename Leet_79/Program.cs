namespace Leet_79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][] { new char[] { 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
            var result = Exist(board, "ABCCEDB");
        }

        public static bool Exist(char[][] board, string word)
        {
            int m = board.Length;
            int n=board[0].Length;
            bool[][] visited = new bool[m][];
            for(int i = 0; i < visited.Length; i++)
            {
                visited[i]= new bool[n];
            }
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    bool flag = Check(board, visited, word, 0, i, j);
                    if (flag)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool Check(char[][] board, bool[][] visited, string word, int k, int i, int j)
        {
            if (board[i][j] != word[k]) return false;
            else if (k == word.Length - 1) return true;
            visited[i][j] = true;
            var result = false;
            int[][] dir = new int[][] { new int[2] { 0, 1 }, new int[2] { 0, -1 }, new int[2] { 1, 0 }, new int[2] { -1, 0 } };
            foreach (int[] item in dir)
            {
                int newi = i + item[0];
                int newj = j + item[1];
                if (newi >= 0 && newi < board.Length && newj >= 0 && newj < board[0].Length && !visited[newi][newj])
                {
                    result = Check(board, visited, word, k + 1, newi, newj);
                    if (result) //这里如果找到满足条件的了，终端循环，返回。
                    {
                        break;
                    }
                }
            }
            visited[i][j] = false;

            return result;
        }
    }
}