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
            PrintArray(MergeSort_Recursive(array));
            Console.ReadKey();
        }

        //Runtime: nLog2(n)
        public static int[] MergeSort_Recursive(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int middle = array.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[array.Length - middle];

            Array.Copy(array, left, middle);
            Array.Copy(array, middle, right, 0, right.Length);

            left = MergeSort_Recursive(left);
            right = MergeSort_Recursive(right);

            return DoMerge(left, right);
        }

        public static int[] DoMerge(int[] left, int[] right)
        {
            List<int> leftList = left.OfType<int>().ToList();
            List<int> rightList = right.OfType<int>().ToList();
            List<int> resultList = new List<int>();

            while (leftList.Count > 0 || rightList.Count > 0)
            {
                if (leftList.Count > 0 && rightList.Count > 0)
                {
                    // Compare the 2 lists, append the smaller element to the result list
                    // and remove it from the original list.
                    if (leftList[0] <= rightList[0])
                    {
                        resultList.Add(leftList[0]);
                        leftList.RemoveAt(0);
                    }
                    else
                    {
                        resultList.Add(rightList[0]);
                        rightList.RemoveAt(0);
                    }
                }

                else if (leftList.Count > 0)
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else if (rightList.Count > 0)
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            // Convert the resulting list back to a static array
            int[] result = resultList.ToArray();
            return result;
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
