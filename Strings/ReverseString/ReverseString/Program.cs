using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reverse = "";
            for (int i = input.Length - 1; i > -1;  i--)
            {
                reverse += input[i];
            }
            Console.WriteLine(reverse);
            Console.ReadKey();
        }
    }
}
