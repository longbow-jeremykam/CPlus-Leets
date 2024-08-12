using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Ways_To_Form_Sum_M
{
    internal class Program
    {
        public static int[] memo;
        static void Main(string[] args)
        {
            int[] coins = { 1, 4, 5, 8};

            Console.WriteLine(numOfWays(87, coins));

            Console.ReadKey();
        }

        public static int numOfWays(int m, int[] coins)
        {
            memo = new int[m + 1];

            memo[0] = 1;

            for (int i = 1; i < m + 1; i++)
            {
                memo[i] = 0;

                foreach(int coin in coins)
                {
                    int temp = i - coin;

                    if (temp < 0)
                    {
                        continue;
                    }

                    memo[i] = memo[i] + memo[temp];
                }
            }

            return memo[m];
        }
    }
}
