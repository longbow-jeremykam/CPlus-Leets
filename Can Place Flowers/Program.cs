using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can_Place_Flowers
{
    internal class Program
    {
        //Watch: https://www.youtube.com/watch?v=ZGxqqjljpUI
        //Intuition:
        //Firstly, we have to consider edge cases:
        /*
         * [1, 0, 1] - there is no space to plant a flower
         * [1, 0, 0, 1] - no space to plant a flower
         * [1, 0, 0, 0, 1] - there IS a space to plant a flower (n = 1)
         * 
         * But is that it? How about:
         * [0, 0, 1] - We already stated previously that two contiguous zeroes means that
         *              there is no space a flower to be planted
         * 
         * How do we address this?
         * We assume that the edges of the flowerbed have empty spots like so:
         * 0 [0, 0, 1] 0
         * 
         * This way, the algorithm is able to count both edges of the array to plant a flower
         * Adding a zero to both edges of the array will not affect the answer but only to account
         * for 'edge' cases ;)
         * 
         * 0 [1, 0, 0, 0, 1] 0
         */

        static void Main(string[] args)
        {
            //0 = empty
            //1 = occupied
            Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2));

            Console.ReadKey();
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            //Resizing and rearranging array elements because C# arrays are stubborn...
            Array.Resize(ref flowerbed, flowerbed.Length + 2);
            Array.Copy(flowerbed, 0, flowerbed, 1, flowerbed.Length - 1);
            flowerbed[0] = 0;
            flowerbed[flowerbed.Length - 1] = 0;

            //for each index of i, ....as long as i is less than l - 1, increment i
            for (int i = 1; i < flowerbed.Length - 1; i++)
            {
                if (n <= 0)
                {
                    break;
                }

                //check the previous, current and next element
                //if all elements are zero, a flower can be planted
                if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    //we can change the current element to 1
                    flowerbed[i] = 1;
                    //and decrement n
                    n--;

                    //this way, we save space and reduce memory
                }
            }

            return n <= 0 ? true : false;
        }

        //Old Solution
        //public static bool CanPlaceFlowers(int[] flowerbed, int n)
        //{
        //    int counter = 0;
        //    if (flowerbed.Length > 1)
        //    {
        //        if (flowerbed[0] + flowerbed[1] == 0)
        //        {
        //            counter++;
        //        }
        //        if (flowerbed[flowerbed.Length - 1] + flowerbed[flowerbed.Length - 2] == 0 && flowerbed.Length > 2)
        //        {
        //            counter++;
        //        }

        //        if (flowerbed.Length >= 5)
        //        {
        //            int i = 3;
        //            while (i < flowerbed.Length - 1)
        //            {
        //                if (flowerbed[i] + flowerbed[i - 1] + flowerbed[i - 2] == 0)
        //                {
        //                    counter++;
        //                    i += 2;
        //                }
        //                else
        //                {
        //                    i++;
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (flowerbed[0] == 0)
        //        {
        //            counter++;
        //        }
        //    }

        //    return (counter >= n) ? true : false;
        //}
    }
}
