using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WordsInFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\", @"TextFiles\")) + "article1.txt";

            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                PrintDictionary(CountWords(NormalizeText(text))); 
            }
            else
            {
                Console.WriteLine("This file does not exist in this folder.");
            }
            Console.ReadKey();
        }

        public static string[] NormalizeText(string text)
        {
            text.Trim();
            string[] input = text.Split(' ');
            string[] words = new string[input.Length]; 

            for (int i = 0; i < input.Length; i ++)
            {
                input[i] = input[i].ToLower();
                words[i] = TrimPunctuation(input[i]);
            }
            return words;
        }

        public static string TrimPunctuation(string value)
        {
            int removeFromStart = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsPunctuation(value[i]))
                {
                    removeFromStart++;
                }
                else
                {
                    break;
                }
            }

            // Count end punctuation.
            int removeFromEnd = 0;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (char.IsPunctuation(value[i]))
                {
                    removeFromEnd++;
                }
                else
                {
                    break;
                }
            }
            // No characters were punctuation.
            if (removeFromStart == 0 &&
                removeFromEnd == 0)
            {
                return value;
            }
            // All characters were punctuation.
            if (removeFromStart == value.Length &&
                removeFromEnd == value.Length)
            {
                return "";
            }
            // Substring.
            return value.Substring(removeFromStart,
                value.Length - removeFromEnd - removeFromStart);
        }

        public static Dictionary<string, int> CountWords(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                }
                else
                {
                    dict[word]++;
                }
            }
            return dict;
        }

        public static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value.ToString());
            }
        }

    }
}
