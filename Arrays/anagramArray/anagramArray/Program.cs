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
            string[] sortedArray = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                sortedArray[i] = SortWord(inputArray[i]);
            }
            Dictionary<string, List<string>> dict = new Dictionary<string,List<string>>();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = i + 1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[i] == sortedArray[j])
                    {
                        if (dict.ContainsKey(inputArray[i]))
                        {
                            dict[sortedArray[i]].Add(inputArray[j]);
                        }                            
                        else
                        {
                            dict.Add(inputArray[i], new List<string> { inputArray[j] });
                        }
                    }
                }

            }
            List<List<string>> result = new List<List<string>>();
            foreach(KeyValuePair<string, List<string>> pair in dict)
            {
                pair.Value.Add(pair.Key);
                result.Add(pair.Value);
            }
            Console.Write("[");
            foreach(var element in result)
            {
                Console.Write("[");
                for (int i = 0; i < element.Count; i++)
                {
                    Console.Write(element[i]);
                    if(i != element.Count -1)
                        Console.Write(" ");
                }
                Console.Write("]");
            }
            Console.Write("]");
            Console.ReadKey();
        }

        public static string SortWord(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort(wordChars);
            return new string(wordChars);
        }
        public static void PrintNicely(List<List<string>> lisfOfLists)
        {

        }
    }
}
