using System.Collections;

namespace Leet_200
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            char[][] grid = new char[][] { new char[] { '1', '1', '1', '1', '0' }, new char[] { '1', '1', '0', '1', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '0', '0', '0' } };
            int result = NumIslands(grid);
        }

        public static int NumIslands(char[][] grid)
        {
            int ans = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        ans++;
                        BFS(grid, i, j);
                    }
                }
            }
            return ans;
        }

        public static void DFS(char[][] grid,int i, int j)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            if(i<0 || j< 0 || i>=m || j>=n || grid[i][j] != '1')
            {
                return;
            }
            grid[i][j] = '0';
            DFS(grid, i + 1, j);
            DFS(grid, i - 1, j);
            DFS(grid, i, j + 1);
            DFS(grid, i, j - 1);
        }

        public static void BFS(char[][] grid,int i,int j)
        {
            List<int> list = new List<int>();
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { i, j });
            while (queue.Count != 0)
            {
                int[] cur = queue.Dequeue();
                i = cur[0];
                j = cur[1];
                if(i-1>=0 && grid[i - 1][j] == '1')
                {
                    grid[i - 1][j] = '0';
                    queue.Enqueue(new int[] { i-1, j });
                }
                if (i + 1 < grid.Length && grid[i + 1][j] == '1')
                {
                    grid[i + 1][j] = '0';
                    queue.Enqueue(new int[] { i + 1, j });
                }
                if (j - 1 >= 0 && grid[i][j - 1] == '1')
                {
                    grid[i][j - 1] = '0';
                    queue.Enqueue(new int[] { i, j - 1});
                }
                if (j + 1 < grid[0].Length && grid[i][j + 1] == '1')
                {
                    grid[i][j + 1] = '0';
                    queue.Enqueue(new int[] { i, j + 1});
                }
            }
        }
    }

    public interface IIf1
    {
        protected static int count = 1;
        void GetString();
    }
}