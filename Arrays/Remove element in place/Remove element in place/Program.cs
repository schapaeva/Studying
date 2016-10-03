using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_element_in_place
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int val = Int32.Parse(Console.ReadLine());
            int length = RemoveElement(nums, val);
            Console.WriteLine("New length: " + length.ToString() + "\n");
            foreach (int n in nums)
            {
                Console.Write(n.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
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
    }
}
