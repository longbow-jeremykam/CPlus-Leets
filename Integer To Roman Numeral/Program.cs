using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_To_Roman_Numeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");

            String numberStr = Console.ReadLine().Trim();
            int number = Convert.ToInt32(numberStr);

            Console.WriteLine(Numeral(number));
            
            Console.ReadKey();
        }

        public static String Numeral(int num)
        {
            string ans = string.Empty;
            string[] symbols = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
            int[] n = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            //999
            for (int i = 0; num != 0 && i < 13; i++)
            {
                while (num >= n[i])
                {
                    num -= n[i];
                    ans += symbols[i];
                }
            }

            return ans;
        }
    }
}
