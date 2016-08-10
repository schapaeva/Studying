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
            MergeSort_Recursive(array, 0, array.Length - 1);
            PrintArray(array);
            Console.ReadKey();
        }

        //Runtime: nLog2(n)
        public static void MergeSort_Recursive(int[] array, int left, int right)
        {
            if (left < right && array.Length > 1)
            {
                int mid = (right + left) / 2;
                MergeSort_Recursive(array, left, mid);
                MergeSort_Recursive(array, mid + 1, right);

                DoMerge(array, left, (mid + 1), right);
            }            
        }

        public static void DoMerge(int[] array, int left, int mid, int right)
        {
            int i, left_end, num_elements, tmp_pos;
            int[] temp = new int[array.Length];

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = right - left + 1;

            while (left <= left_end && mid <= right)
            {
                if (array[left] <= array[mid])
                    temp[tmp_pos++] = array[left++];
                else
                    temp[tmp_pos++] = array[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = array[left++];

            while (mid <= right)
                temp[tmp_pos++] = array[mid++];

            for (i = 0; i < num_elements; i++)
            {
                array[right] = temp[right];
                right--;
            }

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
