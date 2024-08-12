using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Compression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compress(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }));

            Console.ReadKey();
        }

        public static int Compress(char[] chars)
        {
            int k = 0;
            for (int i = 0, j = 1; j < chars.Length; j++)
            {
                if (chars[j] != chars[i])
                {
                    chars[k] = chars[i];
                    if (j - i > 1)
                    {
                        k++;
                        chars[k] = Convert.ToChar(j - i);
                    }

                    k++;
                    i = j;
                }

                if (j + 1 == chars.Length)
                {
                    chars[k] = chars[i];
                    if (j - i + 1 > 1)
                    {
                        k++;
                        chars[k] = Convert.ToChar(j - i + 1);
                    }
                }
            }

            return k + 1;
        }
    }
}
