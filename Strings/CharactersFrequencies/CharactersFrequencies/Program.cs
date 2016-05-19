using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintDictionary(ParseString(input));
            Console.ReadKey();
        }

        public static Dictionary<char, int> ParseString(string input)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++ ;
                }
                else
                {
                    dict.Add(input[i], 1);
                }
            }
            return dict;
        }

        public static void PrintDictionary(Dictionary<char, int> dict)
        {
            foreach(KeyValuePair<char, int> pair in dict)
            {
                Console.Write("({0},{1})", pair.Key, pair.Value);
            }
        }
    }
}
