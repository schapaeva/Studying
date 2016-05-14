using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(temp, Int32.Parse);
            QuickSort(array, 0, array.Length - 1);
            PrintArray(array);
            Console.ReadLine();
        }

        public static int Partition(int[] array, int left, int right)
        {
            int pivot = array[(left + right) / 2];
            Console.WriteLine("Pivot: {0}", pivot.ToString());
            while (true)
            {
                while(array[left] < pivot)
                    left++;
                while (array[right] > pivot)
                    right--;
                if (array[left] == pivot && array[right] == pivot)
                    left++;
                if (left < right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    PrintArray(array);
                    return right;
                }
            }
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);

                if (pivotIndex > 1)
                    QuickSort(array, left, pivotIndex - 1);
                if (pivotIndex + 1 < right)
                    QuickSort(array, pivotIndex + 1, right);
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach (int val in array)
                Console.Write(val.ToString() + " ");
            Console.Write("\n");
        }

    }
}
