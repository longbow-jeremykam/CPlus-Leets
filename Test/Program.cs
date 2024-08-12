using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ProductExceptSelf(new int[] {4, 5, 8, 1, 2});
            int[] array = ProductExceptSelf(new int[] { 4, 5, 8, 1, 2 });

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Leng    th];

            result[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int prod = 1;
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                result[j] = result[j] * prod;
                prod *= nums[j];
            }

            return result;
        }

    }
}
