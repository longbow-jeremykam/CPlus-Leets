using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_Maze
{
    internal class Program
    {
        public static int[,] memo;
        static void Main(string[] args)
        {
            Console.WriteLine(gridPaths(25,25));

            Console.ReadKey();
        }

        public static Int64 gridPaths(int n, int m)
        {
            memo = new int[n + 1, m + 1];

            for(int i = 1; i < n + 1; i++)
            {
                memo[i, 1] = 1;
            }
            for (int j = 1; j < m + 1; j++)
            {
                memo[1, j] = 1;
            }

            for (int i = 2; i < n + 1; i++)
            {
                for (int j = 2; j < m + 1; j++)
                {
                    memo[i, j] = memo[i - 1, j] + memo[i, j - 1];
                }
            }

            return memo[n, m];
        }
    }
}
