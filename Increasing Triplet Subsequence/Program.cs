using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Triplet_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IncreasingTriplet(new int[]{ 8, 6, 9, 3, 12 }));

            Console.ReadKey();
        }

        public static bool IncreasingTriplet(int[] nums)
        {
            int n1 = int.MaxValue;
            int n2 = int.MaxValue;

            foreach (int i in nums)
            {
                if (i > n2)
                {
                    return true;
                }

                if (i <= n1)
                {
                    n1 = i;
                }else if (i <= n2)
                {
                    n2 = i;
                }
            }

            return false;
        }
    }
}
