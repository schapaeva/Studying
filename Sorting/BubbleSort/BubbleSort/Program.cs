using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tmp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(tmp, Int32.Parse);
            for (int j = array.Length - 1; j > 0 ; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                        Exchange(array, i, i + 1);
                }
            }
            PrintArray(array);
            Console.ReadKey();
        }

        public static void Exchange(int[] array, int index1, int index2)
        {
            int tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
                Console.Write(i.ToString() + " ");
        }
    }
}
