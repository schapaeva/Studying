using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilterString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string you want to filter: ");
            Console.WriteLine(filterString(Console.ReadLine()));
            Console.ReadLine();            
        }

        public static string filterString(string input)
        {
            char[] cleanString = new char[input.Length];
            Regex regex = new Regex(@"[A-Za-z]");
            int ind = 0;

            foreach (char letter in input)
            {
                if (regex.IsMatch(letter.ToString()))
                {
                    cleanString[ind] = letter;
                    ind++;
                }
            }
            return new string(cleanString, 0, cleanString.Length -1);
        }
        
    }

}
