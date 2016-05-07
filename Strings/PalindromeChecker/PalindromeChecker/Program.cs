using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(Console.ReadLine()));
            Console.ReadKey();
        }

        public static bool IsPalindrome(string input)
        {
            bool palindrome = true;
            for (int i = 0; i < input.Length / 2 + 1; i++ )
            {
                if(input[i] != input[input.Length - i -1])
                {
                    palindrome = false;
                    break;
                }                
            }
            return palindrome;
        }
    }
}
