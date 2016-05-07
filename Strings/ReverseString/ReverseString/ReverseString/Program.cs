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
            char[] arr = (Console.ReadLine()).ToCharArray();
            string reverse = String.Empty;
            for (int i = arr.Length - 1; i > -1;  i--)
            {
                reverse += arr[i];
            }
            Console.WriteLine(reverse);
            Console.ReadKey();
        }
    }
}
