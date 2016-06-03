using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagramArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');

            Dictionary<string, List<string>> dict = new Dictionary<string,List<string>>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                string sortedWord = SortWord(inputArray[i]);
                if (!dict.ContainsKey(sortedWord))
                    dict.Add(sortedWord, new List<string> { inputArray[i] } );
                else
                    dict[sortedWord].Add(inputArray[i]);           
            }

            PrintNicely(ConvertDictToList(dict));
            Console.ReadKey();
        }

        public static string SortWord(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort(wordChars);
            return new string(wordChars);
        }

        public static List<List<string>> ConvertDictToList(Dictionary<string, List<string>> dict)
        {
            List<List<string>> result = new List<List<string>>();
            foreach (KeyValuePair<string, List<string>> pair in dict)
                result.Add(pair.Value);
            return result;
        }
        public static void PrintNicely(List<List<string>> lisfOfLists)
        {
            Console.Write("[");
            foreach (var element in lisfOfLists)
            {
                Console.Write("[");
                for (int i = 0; i < element.Count; i++)
                {
                    Console.Write(element[i]);
                    if (i != element.Count - 1)
                        Console.Write(" ");
                }
                Console.Write("]");
            }
            Console.Write("]");
        }
    }
}
