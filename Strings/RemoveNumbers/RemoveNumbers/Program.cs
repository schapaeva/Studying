using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(RemoveNumbersRegex(str));
            Console.WriteLine(RemoveNumbers(str));
            Console.ReadKey();
        }

        public static string RemoveNumbersRegex(string str)
        {
            if (str.Length == 0 || str == null) return str;
            return Regex.Replace(str, @"\d", "");
        }

        public static string RemoveNumbers(string str)
        {
            if (str.Length == 0 || str == null) return str;
            List<char> chars = new List<char>();
            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                    chars.Add(str[i]);
            }
            return new string(chars.ToArray());
        }
    }
}
