using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Merge_Strings_Alternately
{
    //LESSON LEARNED:
    //EFFICIENTLY USE POINTERS, TWO BIRDS WITH ONE STONE
    //TO REDUCE THE NUMBER OF VARIABLES AND LOOPS
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mergeAlternately("abc", "pqrst"));

            Console.ReadKey();
        }

        public static string mergeAlternately(string word1, string word2)
        {
            StringBuilder result = new StringBuilder("");

            //OPTIMIZED
            for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
            {
                if (i < word1.Length)
                {
                    result.Append(word1[i]);
                }

                if (i < word2.Length)
                {
                    result.Append(word2[i]);
                }
            }

            //OLD SOLUTION
            //int i = 0;
            //int j = 0;

            //while (i < word1.Length && j < word2.Length)
            //{
            //    result.Append(word1[i]);
            //    result.Append(word2[j]);

            //    i++;
            //    j++;
            //}

            //if (word1.Length >= i)
            //{
            //    for (; word1.Length > i; i++)
            //    {
            //        result.Append(word1[i]);
            //    }
            //}

            //if (word2.Length >= j)
            //{
            //    for (; word2.Length > j; j++)
            //    {
            //        result.Append(word2[j]);
            //    }
            //}

            return result.ToString();
        }
    }
}
