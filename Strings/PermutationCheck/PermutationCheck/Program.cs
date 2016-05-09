using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter first string: ");
            string input1 = Console.ReadLine();
            Console.Write("Please, enter second string: ");
            string input2 = Console.ReadLine();

            Console.WriteLine(IsPermutation2(input1, input2).ToString());
            Console.WriteLine(IsPermutation1(input1, input2).ToString());


            Console.ReadKey();
        }

        //This is method is based on counting characters in the first string and then comparing it to another string characters.
        public static bool IsPermutation1(string input1, string input2)
        {
            if (input1.Length != input2.Length)
                return false;
            int[] countChars = new int[128]; //assumption that we use ASCII characters
            foreach(char ch in input1) //count how many time every character meets in the first string 
                countChars[ch]++;

            for (int i = 0; i < input2.Length; i++)
            {
                int ch = (int)input2[i];
                if (--countChars[ch] < 0)
                    return false;                
            }
            return true;
        }
        //This is a string sorting method 
        public static string SortString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

        //This is method is based on sorting strings anf then compare one to another
        public static bool IsPermutation2(string input1, string input2)
        {
            if (input1.Length != input2.Length)
                return false;
            input1 = SortString(input1);
            input2 = SortString(input2);

            return input1.Equals(input2);
        }
    }
}
