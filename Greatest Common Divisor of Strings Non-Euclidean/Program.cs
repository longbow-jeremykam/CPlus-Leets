using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor_of_Strings_Non_Euclidean
{
    //GREEDY ITERATIVE APPROACH
    //Intuition:
    //take the first substring starting from one character and check whether repeating it back to back
    //constructs the full string
    //if yes, make sure both string lengths are divisible by the length of the GCD substring
    //if yes, calculate factors by dividing both of the string lengths by the GCD substring length
    //reconstruct by putting the substring by factor times
    
    //substring = AB
    //factor = 3
    //final string = ABABAB (3x AB)

    //finally, check whether the string is still the same as the original
    //if yes, GCD of both strings have been found
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GcdOfStrings("ABCABC", "ABC"));

            Console.ReadKey();
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            //helper function
            bool isDivisor(int l)
            {
                //check if l is a factor of the length of both strings, if either returns non=zero
                if (str1.Length % l != 0 || str2.Length % l != 0)
                {
                    //->
                    return false;
                }

                //factors
                int f1 = str1.Length / l;
                int f2 = str2.Length / l;

                //construct the substrings by repeating them by their factor
                //if it is the same for both strings
                //return true, GCD found between both strings
                return string.Concat(Enumerable.Repeat(str1.Substring(0, l), f1)) == str1 && string.Concat(Enumerable.Repeat(str1.Substring(0, l), f2)) == str2;
            }

            //for each index l until 1
            for (int l = Math.Min(str1.Length, str2.Length); l > 0; l--)
            {
                //check if substring is a divisor
                if (isDivisor(l))
                {
                    //GCD found
                    return str1.Substring(0, l);
                }
            }

            return "";
        }


    }
}
