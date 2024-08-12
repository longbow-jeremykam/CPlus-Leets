using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Reverse_Words_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("a"));

            Console.ReadKey();
        }

        public static string ReverseWords(string s)
        {
            string result = "";
            if (s.Length == 0 || s.Equals(" "))
            {
                return result;
            }else if (s.Length == 1)
            {
                return s;
            }

            List<string> words = GetWords(s);

            foreach (string word in words)
            {
                result += word + " ";
            }

            return (result[result.Length - 1] == ' ')? result.Remove(result.Length - 1): result;
        }

        public static List<string> GetWords(string s)
        {
            List<string> words = new List<string>();

            for (int i = s.Length - 1, j = i; i > 0; i--)
            {
                if (s[i] == ' ' && s[i - 1] != ' ') j = i;
                else if (s[i] != ' ' && s[i - 1] == ' ')
                {
                    if (j == s.Length - 1 && s[j] != ' ')
                    {
                        words.Add(s.Substring(i));
                    }
                    else
                    {
                        words.Add(s.Substring(i, j - i));
                    }

                }

                if (i - 1 == 0 && s[i - 1] != ' ')
                {
                    words.Add(s.Substring(i - 1, j + ((s[j] == ' ') ? 0 : 1)));
                }
            }

            return words;
        }
    }
}
    