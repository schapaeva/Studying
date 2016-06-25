using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramCount
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(AnagramCount(Console.ReadLine()).ToString());
            }
        }
        public static int AnagramCount(string input)
        {
            if (input.Length % 2 != 0 || input.Length <= 1)
                return -1;
            string s1 = input.Substring(0, input.Length / 2).ToLower();
            string s2 = input.Substring(input.Length / 2, input.Length / 2).ToLower();
            // a:1 b:1 x:2 || b:2 x:2
            Dictionary<char, int> s1Dict = StringToDictionary(s1);
            Dictionary<char, int> s2Dict = StringToDictionary(s2);
            int sameChars = 0;
            foreach (KeyValuePair<char, int> s1pair in s1Dict)
            {
                if (s2Dict.ContainsKey(s1pair.Key))
                {
                    sameChars += Math.Min(s1pair.Value, s2Dict[s1pair.Key]);
                }
            }

            return s1.Length - sameChars;
        }
        public static Dictionary<char, int> StringToDictionary(string input)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in input)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 1);
                }
                else
                {
                    dict[ch]++;
                }
            }
            return dict;
        }
    }
}
