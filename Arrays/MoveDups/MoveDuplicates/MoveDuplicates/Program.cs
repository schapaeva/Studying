using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp_arr = Console.ReadLine().Split(' ');
            int[] input = Array.ConvertAll(temp_arr, Int32.Parse);
            List<int> unique = new List<int>();
            List<int> duplicates = new List<int>(); 

            for (int i = 0; i < input.Length; i++)
            {
                bool found = false;
                for (int j = i + 1; j < input.Length; j++ )
                {
                    if (input[i] == input[j])
                    {
                        found = true;
                        duplicates.Add(input[j]);
                    }   
                }
                if (!found)
                    unique.Add(input[i]);
            }

            input = unique.ToArray();
            int[] duplicatesArray = duplicates.ToArray();
            PrintIntArray(input);
            PrintIntArray(duplicatesArray);

            Console.ReadKey();            
        }

        public static void PrintIntArray(int[] array)
        {
            foreach (int value in array)
                Console.Write(value.ToString() + " ");
            Console.Write("\n");
        }
    }
}
