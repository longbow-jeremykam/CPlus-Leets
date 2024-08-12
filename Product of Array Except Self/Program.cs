using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Product_of_Array_Except_Self
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = ProductExceptSelf(new int[] { -1, 0, 1, 3 });

            foreach(int num in result)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

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

        //public static int[] ProductExceptSelf(int[] nums)
        //{
        //    if (nums.Length <= 2)
        //    {
        //        return new int[] { nums[1], nums[0] };
        //    }

        //    int left = 0;
        //    int i = 0;
        //    int right = nums.Length - 1;

        //    int[] products = new int[nums.Length];

        //    while (i < nums.Length)
        //    {
        //        if (i == 0)
        //        {
        //            products[i] = Product(nums, left + 1, right);
        //        }
        //        else if (i == nums.Length - 1)
        //        {
        //            products[i] = Product(nums, left, right - 1);
        //        }
        //        else
        //        {
        //            products[i] = Product(nums, left, i - 1) * Product(nums, i + 1, right);
        //        }

        //        i++;
        //    }

        //    return products;
        //}

        //public static int Product(int[] nums, int l, int r)
        //{
        //    int product = nums[l];
        //    for (int i = l + 1; i <= r; i++)
        //    {
        //        if (nums[i] == 0)
        //        {
        //            return 0;
        //        }

        //        product *= nums[i];
        //    }

        //    return product;
        //}
    }
}
