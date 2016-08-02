using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDupsFromSortedArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array of digits: ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            PrintArray(DeleteDuplicated(array));
            Console.ReadKey();
        }
        public static int[] DeleteDuplicated(int[] array)
        {
            List<int> output = new List<int>();
            if (array.Length > 1)
            {
                output.Add(array[0]);
                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (!output.Contains(array[i]))
                        output.Add(array[i]);
                }
                return output.ToArray();
            }
            else
                return array;
        }

        public static void PrintArray(int[] array)
        {
            Console.Write("\nArray: ");
            foreach(int i in array)
            {
                Console.Write(i.ToString() + " ");
            }
        }
    }
}
