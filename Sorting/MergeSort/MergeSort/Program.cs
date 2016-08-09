using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            PrintArray(MergeSort(array));
            Console.ReadKey();
        }

        //Runtime: nLog2(n) + n
        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int middleIndex = array.Length / 2;
            //while ()
            
        }

        public static int[] MergeSubroutine(int[] array1, int[] array2)
        {

        }

        public static void PrintArray<T>(IEnumerable<T> array)
        {
            Console.Write("\nArray: ");
            foreach(var obj in array)
            {
                Console.Write(obj.ToString() + " ");
            }
        }
    }
}
