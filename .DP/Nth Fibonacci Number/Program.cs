using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nth_Fibonacci_Number
{
    internal class Program
    {
        //public static int n = 30;
        //public static int[] memo = new int[n + 1];
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine(fib(n, new int[n + 1]));

            Console.ReadKey();
        }

        public static int fib(int n, int[] memo)
        {
            //base case
            if (memo[n] == n)
            {
                return memo[n];
            }
            if (n <= 2)
            {
                memo[n] = 1;

                return memo[n];
            }

            memo[1] = 1;
            memo[2] = 1;

            //
            for (int i = 3; i < n + 1; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }

            return memo[n];
        }
    }
}
