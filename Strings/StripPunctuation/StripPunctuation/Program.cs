using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripPunctuation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(IsPalindrome(str).ToString());
            Console.ReadKey();
        }

        public static bool IsPalindrome(string s)
        {
            s = NormalizeString(s);
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i]) return false;
            }
            return true;
        }

        public static string NormalizeString(string s)
        {
            s = s.Trim();
            s = s.ToLower();
            char[] arr = s.ToCharArray();

            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c) 
                    //|| char.IsWhiteSpace(c) || c == '-'
                    )));
            return new string(arr);
        }
    }
}
