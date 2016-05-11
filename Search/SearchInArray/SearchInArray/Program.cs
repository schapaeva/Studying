using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] tmp = Console.ReadLine().Split(' ');
                long[] array = Array.ConvertAll(tmp, long.Parse);
                if (CheckArray1(array))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        public static bool CheckArray1(long[] array)
        {
            bool ifFoundIElement = false;
            for (int i = 1; i < array.Length - 1; i++)
            {
                long sum1 = 0, sum2 = 0;
                for (int left = 0; left < i; left++)
                {
                    sum1 += array[left];
                }
                for (int right = i + 1; right < array.Length; right++)
                {
                    sum2 += array[right];
                }
                if (sum1 == sum2)
                {
                    ifFoundIElement = true;
                    break;
                }
            }
            return ifFoundIElement;
        }

        public static bool CheckArray2(long[] array)
        {
            int left_ind = 0;
            int right_ind = array.Length - 1;

            long left_sum = array[left_ind];
            long right_sum = array[right_ind];

            while (left_ind != right_ind)
            {
                if (left_sum < right_sum)
                {
                    left_ind++;
                    left_sum = +array[left_ind];
                }
                else
                {
                    right_ind--;
                    right_sum += array[right_ind];
                }
            }
            return left_sum == right_sum;
        }
    }
}
