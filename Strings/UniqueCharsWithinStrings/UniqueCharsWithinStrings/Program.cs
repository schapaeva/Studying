using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharsWithinStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int rocks = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[rocks];
            for (int i = 0; i < rocks; i++)
            {
                input[i] = Console.ReadLine();
            }
            Console.WriteLine(GetGemsNumber(input));
        }

        public static int GetGemsNumber(string[] input)
        {
            string currentGem = input[0];
            for (int rock = 1; rock < input.Length; rock++)
            {
                currentGem = FindGems(currentGem, input[rock]);           
            }
            return currentGem.Length;
        }

        public static string FindGems(string one, string two)
        {
            string gems = "";
            for (int i = 0; i < one.Length; i++)
            {
                for (int j = 0; j < two.Length; j++)
                {
                    if (one[i] == two[j] && !gems.Contains(one[i]))
                    {
                        gems += one[i];
                        break;
                    }
                }
            }
            return gems;
        }
    }
}
