using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseVowels
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseVowels(Console.ReadLine()));
            Console.ReadKey();
        }

        public static string ReverseVowels(string s)
        {
            char[] vowels = new char[] { 'a', 'e', 'u', 'i', 'o', 'A', 'E', 'U', 'I', 'O' };
            if (s.Length <= 1)
                return s;

            char[] chars = s.ToCharArray();

            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (!vowels.Contains(chars[i]))
                {
                    i++;
                    continue;
                }

                if (!vowels.Contains(chars[j]))
                {
                    j--;
                    continue;
                }

                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;

                i++;
                j--;
            }

            return new string(chars);
        }
    }
}
