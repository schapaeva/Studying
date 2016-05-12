using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(temp, Int32.Parse);
            SortIntArray(array);
            PrintArray(array);
            Console.ReadKey();
        }

        public static int FindMinPosition(int[] array, int start)
        {
            int minPosition = start;
            for (int i = start; i < array.Length; i++)
            {
                if (array[i] < array[minPosition])
                    minPosition = i;
            }
            return minPosition;
        }

        public static void SortIntArray(int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = FindMinPosition(array, i);
                if (min != i)
                    Exchange(array, min, i);
            }
        }

        public static void Exchange(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static void PrintArray(int[]array)
        {
            foreach (int val in array)
                Console.Write(val.ToString() + " ");
        }
    }
}
