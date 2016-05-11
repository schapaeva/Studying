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
                CheckArray(array);
            }
        }

        public static bool CheckArray(long[] array)
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
                    Console.WriteLine("YES");
                    break;
                }
            }
            if (!ifFoundIElement)
                Console.WriteLine("NO");
            return ifFoundIElement;
        }
    }
}
