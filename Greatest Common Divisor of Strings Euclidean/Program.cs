using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor_of_Strings_Euclidean
{
    //USE DATA PROPERTIES TO MANIPULATE (ex. their length in this question)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GcdOfStrings("ABCABC", "ABC"));

            Console.ReadKey();
        }

        
        public static string GcdOfStrings(string str1, string str2)
        {
            if (!(str1 + str2).Equals(str2 + str1))
            {
                return "";
            }

            int gcd = (str1.Length > str2.Length) ? EuclidDiv(str1.Length, str2.Length) : EuclidDiv(str2.Length, str1.Length);

            return (str1.Length > str2.Length) ? str1.Substring(0, gcd) : str2.Substring(0, gcd);
        }

        public static int EuclidDiv(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return EuclidDiv(b, a % b);
        }
    }
}
