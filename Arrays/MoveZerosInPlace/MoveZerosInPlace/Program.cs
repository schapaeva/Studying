using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZerosInPlace
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            MoveZeroes(array);
            PrintArray(array);
            Console.ReadKey();
        }

        public static void MoveZeroes(int[] nums)
        {
            //nums = [0, 1, 0, 3, 12]
            int lastNotZero = nums.Length - 1; //nums = 4
            for (int i = nums.Length - 1; i >= 0; i--) // i = 2 
            {
                if (nums[i] == 0) // yep
                {
                    for (int j = i; j < lastNotZero; j++)  // j = 2 -> 4
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp; // []
                    }
                    lastNotZero--;
                }
            }
        }

        public static void PrintArray<T>(IEnumerable<T> array)
        {
            foreach(var item in array)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
