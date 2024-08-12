using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_With_the_Greatest_Number_of_Candies
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> result = new bool[candies.Length];

            int max = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > max)
                {
                    max = candies[i];
                }
            }

            for (int j = 0; j < result.Count; j++)
            {
                if (candies[j] + extraCandies >= max)
                {
                    result[j] = true;
                }
                else
                {
                    result[j] = false;
                }
            }

            return result;
        }
    }
}
