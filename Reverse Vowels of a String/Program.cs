using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Vowels_of_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(reverseVowels("hello"));

            Console.ReadKey();
        }

        public static string reverseVowels(string s)
        {
            char[] chars = s.ToCharArray();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0, j = chars.Length - 1; i < chars.Length - i - 1; i++, j--)
            {
                while (!vowels.Contains(chars[i]) && i < chars.Length - 1)
                {
                    i++;
                }
                while (!vowels.Contains(chars[j]) && j > 1)
                {
                    j--;
                }

                if (i >= j || !vowels.Contains(chars[i]) || !vowels.Contains(chars[j]))
                {
                    break;
                }

                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }

            //int i = 0;
            //int j = chars.Length - 1;

            //while (i < j)
            //{
            //    if (vowels.Contains(chars[i]) && vowels.Contains(chars[j]))
            //    {
            //        char c = chars[i];
            //        chars[i] = chars[j];
            //        chars[j] = c;

            //        i++;
            //        j--;
            //    }else if (!vowels.Contains(chars[i]) && vowels.Contains(chars[j]))
            //    {
            //        i++;
            //    }else if (vowels.Contains(chars[i]) && !vowels.Contains(chars[j]))
            //    {
            //        j--;
            //    }
            //    else
            //    {
            //        i++;
            //        j--;
            //    }
            //}

            return new string(chars);
        }
    }
}
