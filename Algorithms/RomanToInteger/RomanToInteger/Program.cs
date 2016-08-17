using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt(Console.ReadLine()).ToString());
            Console.ReadKey();
        }

        public static int RomanToInt(string s)
        {
            s= s.ToLower();
            Dictionary<char, int> roman = PopulateRomanDictionary();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //"MCMXCIV"
                if (i == s.Length - 1)
                    sum += GetIntegerFromRoman(roman, s[i]); 
                else
                {
                    int first = GetIntegerFromRoman(roman, s[i]);
                    int second = GetIntegerFromRoman(roman, s[i + 1]);
                    if ( first >= second)
                    {
                        sum += first;
                    }
                    else
                    {
                        sum += second - first;
                        i++;
                    }
                }
            }
            return sum;
        }

        public static int GetIntegerFromRoman(Dictionary<char, int> roman, char ch)
        {
            if (roman.ContainsKey(ch))
                return roman[ch];
            else
                return -1;
        }

        public static Dictionary<char, int> PopulateRomanDictionary()
        {
            Dictionary<char, int> roman = new Dictionary<char, int>();
            roman.Add('i', 1);
            roman.Add('v', 5);
            roman.Add('x', 10);
            roman.Add('l', 50);
            roman.Add('c', 100);
            roman.Add('d', 500);
            roman.Add('m', 1000);
            return roman;
        }
    }
}
