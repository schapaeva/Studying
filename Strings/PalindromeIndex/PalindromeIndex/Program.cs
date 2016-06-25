using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(PalindromeIndex(Console.ReadLine()));
            }
        }
        public static int PalindromeIndex(string input)
        {
            if (input.Length <= 1)
                return -1;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[0] != input[input.Length - 1 - i])
                {
                    if (IfPalindrome(MakeSubstring(input, i)))
                        return i;
                    else if (IfPalindrome(MakeSubstring(input, input.Length - 1 - i)))
                        return input.Length - 1 - i;
                }
            }
            return -1;
        }

        public static string MakeSubstring(string input, int index)
        {
            string substring = "";
            if (index < 0 || index > input.Length - 1)
                throw new System.ArgumentOutOfRangeException("Index is out of range.");
            //01a34 -> delete 2 index -> sub(0 - 1) + sub(3-end)
            if (index == 0)
            {
                substring = input.Substring(1);
            }
            else if (index == input.Length - 1)
            {
                substring = input.Substring(0, input.Length - 1);
            }
            else
            {
                substring = input.Substring(0, index) + input.Substring(index + 1);
            }
            return substring;
        }

        public static bool IfPalindrome(string input)
        {
            bool palindrome = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
    }
}
