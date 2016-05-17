using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangramChecker
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Console.WriteLine(IfPangram(Console.ReadLine()).ToString());
            Console.ReadKey();
        }

        public static bool IfPangram(string input)
        {
            if (input.Length < 26)
                return false;
            string lower = input.ToLower();
            string alphabit = "abcdefghijklmnopqrstuvwxyz";
            foreach(char ch in alphabit)
            {
                if (!lower.Contains(ch))
                    return false;
            }
            return true;
        }
    }
}
