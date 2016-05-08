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
            Console.WriteLine(ReverseString1(input));
            Console.WriteLine(ReverseString2(input));
            
            Console.ReadKey();
        }

        public static string ReverseString1(string input)
        {
            string reverse = "";
            for (int i = input.Length - 1; i > -1; i--)
            {
                reverse += input[i];
            }
            return reverse;
        }

        public static string ReverseString2(string input)
        {
            char[] chars = input.ToCharArray();
            int end = input.Length -1;
            for (int i = 0; i < end; i++, end--)
            {
                char tmp = chars[i];
                chars[i] = chars[end];
                chars[end] = tmp;
            }
            return new string(chars);
        }

    }
}
