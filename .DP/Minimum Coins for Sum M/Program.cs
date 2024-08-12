using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Coins_for_Sum_M
{
    internal class Program
    {
        public static int target = 4000;
        public static int[] memo = new int[target + 1];

        static void Main(string[] args)
        {
            int[] coins = { 1, 4, 5 };

            Console.WriteLine(minimumCoins(target, coins));

            Console.ReadKey();
        }

        public static int minimumCoins(int m, int[] coins)
        {
            memo[0] = 0;

            for (int i = 1; i < m + 1; i++)
            {
                foreach(int coin in coins)
                {
                    int temp = i - coin;
                    if (temp < 0)
                    {
                        continue;
                    }

                    memo[i] = minIgnoreNone(memo[i], memo[temp] + 1);
                }
            }

            return memo[m];
        }

        private static int minIgnoreNone(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }else if(b == 0)
            {
                return a;
            }

            return Math.Min(a, b);
        }
    }
}
