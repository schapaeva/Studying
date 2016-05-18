using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Console.WriteLine(CountDeletions(Console.ReadLine()).ToString());
            Console.ReadKey();
        }

        public static int CountDeletions(string input)
        {
            char previous = input[0];
            int deletions = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (previous == input[i])
                {
                    deletions++;
                }
                else
                {
                    previous = input[i];
                }
            }
            return deletions;
        }
    }
}
