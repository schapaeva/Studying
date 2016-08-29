using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_element
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int val = Int32.Parse(Console.ReadLine());
            int result = RemoveElement(array, val);
            PrintArray(array);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    // reduce array size by one
                    n--;
                }
                else
                {
                    i++;
                }
            }
            return n;
        }

        public static void PrintArray<T>(IEnumerable<T> array)
        {
            Console.Write("\n");
            foreach(var item in array)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.Write("\n");
        }

    }
}
