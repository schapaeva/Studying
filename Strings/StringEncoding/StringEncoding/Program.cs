using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncoding
{
    //Questions: Is string in ASCII or Unicode string? 
    // What if compressed string is longer than original string? Should I return original in this case? 
    //Example: abdfg -> a1b1d1f1g1: Original: 5 Compressed: 10

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string to compress: ");
            string input = Console.ReadLine();
            string compressedString = CompressString(input);
            Console.WriteLine(compressedString);
            Console.ReadKey();
        }

        public static string CompressString(string str)
        {
            if (str.Length == 0) return "";
            StringBuilder compressed = new StringBuilder();
            int coundConsecutive = 0;
            for (int i = 0; i < str.Length; i++)
            {
                coundConsecutive++;

                if(i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressed.Append(str[i]);
                    compressed.Append(coundConsecutive);
                    coundConsecutive = 0;
                }
            }
            return compressed.Length <= str.Length ? compressed.ToString() : str ;
        }
    }
}
