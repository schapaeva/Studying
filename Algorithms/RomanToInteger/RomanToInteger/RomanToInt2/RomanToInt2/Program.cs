using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt2
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("CMLII");

        }

        public static int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<char, int> romans = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
            //CMLII
            for (int i = s.Length - 1; i > 0; i--)
            {
                if (romans[s[i]] <= romans[s[i - 1]])
                {
                    result += romans[s[i]];
                }
                else
                {
                    result += (romans[s[i]] - romans[s[i-1]]);
                    i--;                    
                }
            }
            return result += romans[s[0]];
        }
    }
}
