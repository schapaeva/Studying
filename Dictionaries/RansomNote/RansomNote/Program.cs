using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string ransomNote = Console.ReadLine();
            string magazine = Console.ReadLine();
            Console.WriteLine(CanConstruct(ransomNote, magazine).ToString());
            Console.ReadKey();
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine.Length == 0 && ransomNote.Length == 0)
                return true;
            if (magazine.Length == 0)
                return false;
            if (ransomNote.Length == 0)
                return true;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            //Populate dictionary with letters from magazine
            foreach (char ch in magazine)
            {
                if (!dict.ContainsKey(ch))
                    dict.Add(ch, 1);
                else
                    dict[ch]++;
            }

            foreach (char ch in ransomNote)
            {
                if (!dict.ContainsKey(ch) || dict[ch] == 0)
                    return false;
                else
                {
                    dict[ch]--;
                }
            }
            return true;
        }
    }
}
