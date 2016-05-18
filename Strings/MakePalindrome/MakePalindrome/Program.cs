using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakePalindrome
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(PalindromeOperations(Console.ReadLine()).ToString());
            }
        }
        public static int PalindromeOperations(string input)
        {
            int operations = 0;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    operations += MakeEqualCharacters(input[i], input[input.Length - 1 - i]);
                }
            }
            return operations;
        }
        public static int MakeEqualCharacters(char left, char right)
        {
            int operations = 0;
            if (left < right)
            {
                operations = (int)right - (int)left;
            }
            else
            {
                operations = (int)left - (int)right;
            }
            return operations;
        }
    }
}
