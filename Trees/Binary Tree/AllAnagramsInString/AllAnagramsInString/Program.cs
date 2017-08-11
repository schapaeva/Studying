using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnagramsInString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string p = Console.ReadLine();
            IList<int> anagrams = FindAnagrams(s, p);
            foreach (int i in anagrams)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        public static IList<int> FindAnagrams(string s, string p)
        {
            IList<int> result = new List<int>();
            Dictionary<char, int> dict = StringToDict(p);

            if (s.Length > p.Length)
            {
                for (int i = 0; i <= s.Length - p.Length; i++)
                {
                    Dictionary<char, int> dict2 = new Dictionary<char, int>(dict);
                    if (s.Substring(i, p.Length) == p || CheckIfAnagram(s.Substring(i, p.Length), dict2))
                        result.Add(i);
                }
            }
            return result;
        }
        public static bool CheckIfAnagram(string range, Dictionary<char, int> dict)
        {
            foreach (char ch in range)
            {
                if (!dict.ContainsKey(ch))
                    return false;
                else
                {
                    dict[ch]--;
                    if (dict[ch] == 0) dict.Remove(ch);
                }
            }
            if (dict.Count == 0) return true;
            return false;
        }

        public static Dictionary<char, int> StringToDict(string s)
        {
            //char[] chars = s.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (!dict.ContainsKey(ch))
                    dict.Add(ch, 1);
                else
                    dict[ch]++;
            }
            return dict;
        }
    }
}
